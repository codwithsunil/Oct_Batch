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
            LoadGrid();
        }

        private void LoadGrid()
        {
            dataGridBook.DataSource = null;

            dataGridBook.DataSource = DataStoreManager.Books;

            dataGridBook.Refresh();
        }
    }
}
