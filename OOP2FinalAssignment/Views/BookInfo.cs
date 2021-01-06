using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OOP2FinalAssignment.Controllers;

namespace OOP2FinalAssignment.Views
{
    public partial class BookInfo : Form
    {
        //private object gridProducts;

        public BookInfo()
        {
            InitializeComponent();
            gridBooks.DataSource = BookController.GetAllBooks();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            dynamic book = BookController.GetBook(Search.Text);
            if (book != null)
            {
                tBName.Text = book.Name;
                tBAuthor.Text = book.Author;
                tBEdition.Text = book.Edition;
                
            }
            else
            {
                tBName.Text = "";
                tBAuthor.Text = "";
                tBEdition.Text = "";
                MessageBox.Show("can't find the book");
            }
        }

        private void tBSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
