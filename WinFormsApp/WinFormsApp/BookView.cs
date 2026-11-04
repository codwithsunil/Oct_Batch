using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class BookView : Form
    {
        public BookView()
        {
            InitializeComponent();
            LoadGrid("");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="search"></param>
        private void LoadGrid(string search)
        {
            dataGridBook.DataSource = null;

            dataGridBook.DataSource = BookManager.GetAll(search);

            dataGridBook.Refresh();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if (!string.IsNullOrEmpty(search))
            {
                LoadGrid(search);
            }
        }
    }
}
