using E_Commerce.Models.Tables;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_Commerce.Models
{
    public class Database
    {
        SqlConnection conn;
        public Products Products { get; set; }
        public Users Users { get; set; }
        public Database()
        {
            string connString = @"Server=PREETI\SQLEXPRESS;Database=PMS;User Id=sa;Password=12345";
            conn = new SqlConnection(connString);
            Products = new Products(conn);
            Users = new Users(conn);

        }
    }
}