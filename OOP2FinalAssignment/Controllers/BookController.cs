using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2FinalAssignment.Models;
//using OOP2FinalAssignment.Views;

namespace OOP2FinalAssignment.Controllers
{
    public class BookController
    {
        static Database db = new Database();
        public static Book GetBook(string name)
        {
            return db.Books.GetBook(name);
        }
        public static ArrayList GetAllBooks()
        {
            return db.Books.GetAllBooks();
        }
    }
}
