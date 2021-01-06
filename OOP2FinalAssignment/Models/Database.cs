using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2FinalAssignment.Models;

namespace OOP2FinalAssignment.Models
{
    public class Database
    {
        public Books Books { get; set; }
        public Database()
        {
            string connString = "Server=DESKTOP-01TA4PH\\SQLEXPRESS;Integrated Security=True;Database=OOP2";
            SqlConnection conn = new SqlConnection(connString);
            Books = new Books(conn);
        }
    }
}
