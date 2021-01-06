using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
//using OOP2FinalAssignment.Controllers;
using OOP2FinalAssignment.Views;
using System.Collections;

namespace OOP2FinalAssignment.Models
{
    public class Books
    {
        SqlConnection conn;
        public Books(SqlConnection conn)
        {
            this.conn = conn;
        }
        public ArrayList GetAllBooks()
        {
            ArrayList books = new ArrayList();
            conn.Open();
            string query = "SELECT * FROM Books";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Book book = new Book();
                book = new Book();
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));
                books.Add(book);
            }
            conn.Close();
            return books;
        }
        public Book GetBook(string name)
        {
            conn.Open();
            string query = String.Format("SELECT * FROM Books WHERE Name = '{0}'", name);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Book book = null;
            while (reader.Read())
            {
                book = new Book();
                book.Name = reader.GetString(reader.GetOrdinal("Name"));
                book.Author = reader.GetString(reader.GetOrdinal("Author"));
                book.Edition = reader.GetString(reader.GetOrdinal("Edition"));
            }
            conn.Close();
            return book;
        }

    }
}
