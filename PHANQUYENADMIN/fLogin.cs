﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PHANQUYENADMIN.DAO;
namespace PHANQUYENADMIN
{
    public partial class fLogin : Form
    {
        public static String user;
        public fLogin()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string username= textUsername.Text;
            string password= textPassword.Text;
            if(username!=null && password != null)
            {
                if (DataProvider.getInstance(username, password) != null)
                {
                    fEditUser editUser = new fEditUser();
                    fEditRole editRole = new fEditRole();
                    user = username;
                    this.Hide();
                    editRole.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login fail");
                }
            }
            else
            {
                MessageBox.Show("Empty!");
            }
        }
    }
}