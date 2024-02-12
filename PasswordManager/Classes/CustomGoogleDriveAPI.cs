using System;
using System.Collections.Generic;
using System.IO;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System.Threading;
using System.Windows.Forms;
using File = Google.Apis.Drive.v3.Data.File;

namespace PasswordManager.Classes
{
    public static class CustomGoogleDriveAPI
    {
        //static string[] Scopes = { DriveService.Scope.Drive,
        //                           DriveService.Scope.DriveFile };
        static readonly string[] Scopes = { DriveService.Scope.DriveFile };
        static readonly string ApplicationName = "Password Manager";

        #region GOOGLE METHODS

        public static UserCredential GetCredential()
        {
            UserCredential credential;

            using (var stream =
                new FileStream("credentials.json", FileMode.Open, FileAccess.Read))
            {
                // The file token.json stores the user's access and refresh tokens, and is created
                // automatically when the authorization flow completes for the first time.                
                string credPath = "token.json";
                credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    Scopes,
                    "user",
                    CancellationToken.None,
                    new FileDataStore(credPath, true)).Result;
            }
            return credential;
        }

        public static DriveService GetDriveService(UserCredential credential)
        {
            return new DriveService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credential,
                ApplicationName = ApplicationName,
            });
        }

        #endregion

        #region DOWNLOAD

        public static File DownloadFile(
            DriveService service,
            string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            File cloudFile;
            Forms.Main mainForm = Application.OpenForms["Main"] as Forms.Main;

            //Program.SqlConn.Close();
            GC.Collect();
            GC.WaitForPendingFinalizers();

            if ((cloudFile = GetFile(service, fileName)) != null)
            {
                // The file exists in the cloud
                FilesResource.GetRequest request = service.Files.Get(cloudFile.Id);

                using (var memStream = new MemoryStream())
                {
                    //request.MediaDownloader.ProgressChanged += Download_ProgressChanged;
                    request.MediaDownloader.ProgressChanged += (Google.Apis.Download.IDownloadProgress progress) =>
                    {
                        if (progress.Status == Google.Apis.Download.DownloadStatus.Completed)
                            //MessageBox.Show("File was downloaded successfully", "Success!", MessageBoxButtons.OK);
                            MessageBox.Show("File was downloaded successfully");
                    };

                    request.Download(memStream);

                    using (var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.Write))
                    {
                        fileStream.Write(memStream.GetBuffer(), 0, memStream.GetBuffer().Length);
                    }                    
                }

                if (Forms.Login.firstStart)                
                    Application.Restart();
                
                else
                {
                    CustomSQLite.ConnectToDB(Program.AppPw);
                    Utils.SitesFillList(mainForm.Controls.Find("site_TreeView", true)[0], true);
                }

                               

                return cloudFile;
            }
            else
            {
                MessageBox.Show("File doesn't exist in the cloud", "Error!", MessageBoxButtons.OK);
                return null;
            }

        }

        #endregion

        #region UPLOAD

        public static File UploadFile(
            DriveService service,
            string filePath,
            string descrp = "PasswordManager database.")
        {
            if (System.IO.File.Exists(filePath))
            {
                if (GetFile(service, Path.GetFileName(filePath)) != null)
                {
                    // The file already exists in the cloud, must use UpdateFile()                             
                    return UpdateFile(service, filePath);
                }
                else
                {
                    // The file doesn't exist, begin upload                                        
                    File body = new File();
                    FilesResource.CreateMediaUpload request;

                    body.Name = Path.GetFileName(filePath);
                    body.MimeType = Utils.GetMimeType(filePath);
                    body.Description = descrp;
                    // Folder not supported yet
                    // if (parentName != null) body.Parents = new List<string> { GetFolder(service, parentName).Id };                    

                    using (var stream = new FileStream(filePath, FileMode.Open))
                    {
                        try
                        {
                            request = service.Files.Create(body, stream, Utils.GetMimeType(filePath));
                            request.SupportsTeamDrives = true;
                            
                            request.ProgressChanged += (Google.Apis.Upload.IUploadProgress progress) =>
                            {
                                if (progress.Status == Google.Apis.Upload.UploadStatus.Completed)
                                    MessageBox.Show("File was uploaded successfully", "Success!", MessageBoxButtons.OK);
                            };
                            request.Upload();

                            MessageBox.Show("File uploaded", "Success!", MessageBoxButtons.OK);

                            return request.ResponseBody;
                        }
                        catch
                        {
                            MessageBox.Show("Error Occured.", "Error!", MessageBoxButtons.OK);
                            return null;
                        }
                    }
                }
            }
            else
            {                
                MessageBox.Show("The file does not exist.", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }

        public static File UpdateFile(
            DriveService service,
            string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                if (GetFile(service, Path.GetFileName(filePath)) != null)
                {
                    // The file exists and can be updated

                    File body = new File();
                    File oldFile = GetFile(service, Path.GetFileName(filePath));

                    FilesResource.UpdateMediaUpload request;

                    body.Name = Path.GetFileName(filePath);
                    body.MimeType = Utils.GetMimeType(filePath);

                    using (var stream = new FileStream(filePath, FileMode.Open))
                    {
                        try
                        {
                            request = service.Files.Update(body, oldFile.Id, stream, body.MimeType);
                            request.SupportsTeamDrives = true;

                            request.ProgressChanged += (Google.Apis.Upload.IUploadProgress progress) =>
                            {
                                if (progress.Status == Google.Apis.Upload.UploadStatus.Completed)
                                    MessageBox.Show("File was uploaded successfully", "Success!", MessageBoxButtons.OK);
                            };
                            request.Upload();

                            MessageBox.Show("File updated", "Success!", MessageBoxButtons.OK);

                            return request.ResponseBody;
                        }
                        catch
                        {
                            MessageBox.Show("Error Occured.", "Error!", MessageBoxButtons.OK);
                            return null;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("The file does not exist in the cloud.", "Error!", MessageBoxButtons.OK);
                    return null;
                }
            }
            else
            {
                MessageBox.Show("The file does not exist.", "Error!", MessageBoxButtons.OK);
                return null;
            }
        }

        public static File AutoUpdate(
            DriveService service,
            string filePath)
        {
            File cloudFile = null;
            bool success = false;            

            if ((cloudFile = GetFile(service, Path.GetFileName(filePath))) == null)
            {
                // The file in the cloud doesn't exist, must upload
                try
                {
                    UploadFile(service, filePath);
                    MessageBox.Show("The file in the cloud doesn't exist, creating");
                    success = true;                    
                }
                catch
                {
                    success = false;
                }
                
            }
            else if ((cloudFile = GetFile(service, Path.GetFileName(filePath))) != null && System.IO.File.Exists(filePath))
            {
                // Makes sure both files exists before updating one of them

                if (cloudFile.ModifiedTime > System.IO.File.GetLastWriteTime(filePath))
                {
                    // The file in the cloud is newer than the one in the PC, must download
                    try
                    {
                        //MessageBox.Show("Downloading from Cloud", "Downloading", MessageBoxButtons.OK);                        
                        cloudFile = DownloadFile(service, filePath);
                        success = true;                        
                    }
                    catch
                    {
                        MessageBox.Show("An error ocured", "Error!", MessageBoxButtons.OK);
                        success = false;
                    }
                    
                }
                else
                {
                    // The file in the cloud is older than the one in the PC, must upload                    
                    try
                    {
                        //MessageBox.Show("Uploading to Cloud", "Uploading", MessageBoxButtons.OK);
                        cloudFile = UploadFile(service, filePath);
                        success = true;
                    }
                    catch
                    {
                        MessageBox.Show("An error ocured", "Error!", MessageBoxButtons.OK);
                        success = false;
                    }
                }
            }

            return (success) ? cloudFile : null;
        }

        #endregion

        #region GET

        public static File GetFolder(
            DriveService service,
            string folderName = "PasswordManager")
        {
            FilesResource.ListRequest request = service.Files.List();
            request.Fields = @"files(*)";
            request.Q = "name = '" + folderName + "' and mimeType = 'application/vnd.google-apps.folder'";

            IList<File> files = request.Execute().Files;

            return (files.Count == 1) ? files[0] : null;
        }

        public static File GetFile(
            DriveService service,
            string fileName = "passwords.sqlite")
        {
            FilesResource.ListRequest request = service.Files.List();
            request.Fields = @"files(*)";
            request.Q = "name = '" + fileName + "' and trashed = false";

            IList<File> files = request.Execute().Files;

            return (files.Count == 1) ? files[0] : null;
        }

        #endregion

    }
}
