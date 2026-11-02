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
                MessageBox.Show("Valid User");
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

            //LoadGrid();
        }

        //private void LoadGrid()
        //{
        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = loginManager.GetAll();
        //    dataGridView1.Refresh();
        //}

        private void btnDelete_Click(object sender, EventArgs e)
        {
            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;

            loginManager.Remove(logedInuser);

            //LoadGrid();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;
            // now pass this to user Manager 
            UserManager.Add(logedInuser);
            //this will be fetching all the data stored in the list and show

            LoadGrid();

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            User logedInuser = new User();
            logedInuser.UserName = txtUserName.Text;
            logedInuser.Password = txtPassword.Text;
            // now pass this to user Manager 
            UserManager.Remove(logedInuser);

            LoadGrid();
        }


        private void LoadGrid()
        {
            userGridView.DataSource = null;
            userGridView.DataSource = UserManager.GetAll();
            userGridView.Refresh();
        }
    }
}
