using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;
            if (loginManager.IsValidUser(logedInuser) == true)
            {
                Main main = new Main();
                main.Show();
                // hide Login Window : TODO 
            }
            else
            {
                MessageBox.Show("InValid User");
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;
            loginManager.Add(logedInuser);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;
            loginManager.Remove(logedInuser);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;
            // now pass this to user Manager 
            UserManager.Add(logedInuser);


        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;
            // now pass this to user Manager 
            UserManager.Remove(logedInuser);
        }
    }
}
