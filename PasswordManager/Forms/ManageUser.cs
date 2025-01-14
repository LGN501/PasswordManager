﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PasswordManager.Classes;

namespace PasswordManager.Forms
{
    public partial class ManageUser : Form
    {
        private User user;

        public User User { get => user; set => user = value; }

        public ManageUser(int userId)
        {
            InitializeComponent();

            User = User.Get_ById(userId);
        }

        
    }
}
