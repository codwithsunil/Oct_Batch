using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp
{
    public partial class Main : Form
    {
        public Main()
        {
            this.IsMdiContainer = true;
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookView bookView = new BookView();
            bookView.Show();
        }
    }
}
