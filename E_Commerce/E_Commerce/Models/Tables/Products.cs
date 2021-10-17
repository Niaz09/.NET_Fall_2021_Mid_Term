using E_Commerce.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace E_Commerce.Models.Tables
{
    public class Products
    {
        SqlConnection conn;
        public Products(SqlConnection conn)
        {
            this.conn = conn;
        }
        public List<Product> Get()
        {
            conn.Open();
            string query = "Select * from Products";
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            List<Product> products = new List<Product>();
            while (reader.Read())
            {
                Product p= new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Item = reader.GetString(reader.GetOrdinal("Item"))
                };
                products.Add(p);
            }
            conn.Close();
            return products;
        }
        public Product Add(int id)
        {
            conn.Open();
            string query = String.Format("Select * from Products where Id='{0}'",id);
            SqlCommand cmd = new SqlCommand(query, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            Product product = null;
            while (reader.Read())
            {
                product = new Product()
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    Item = reader.GetString(reader.GetOrdinal("Item"))
                };
            }
            conn.Close();
            return product;
        }
    }
}