using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

      
       private Hashtable tables=new Hashtable();

        private string isbn;

        private string bookDetails;

        private void addBookButton_Click(object sender, EventArgs e)
        {
            isbn = isbnTextBox.Text;

            bookDetails = bookDetailsTextBox.Text;

            tables.Add(isbn,bookDetails);

            isbnTextBox.Text = "";
            bookDetailsTextBox.Text = "";
        }

        private void findBookButton_Click(object sender, EventArgs e)
        {
            string search = isbnBox.Text;

            if (tables.ContainsKey(search))
            {
                bookDetailsBox.Text = tables[search].ToString();
                
            }
            else
            {
                MessageBox.Show("Book Not Found");
                bookDetailsBox.Text = "";
            }
        }

      
    }
}
