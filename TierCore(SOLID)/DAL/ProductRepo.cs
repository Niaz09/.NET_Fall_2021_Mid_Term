using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TierCore.Repository;
using TierCore.Repository.Models;

namespace DAL
{
    public class ProductRepo : IRepository<Product, int>
    {
        ECMDbContext db;
        public ProductRepo(ECMDbContext db)
        {
            this.db = db;
        }
        public void Add(Product e)
        {
            db.Products.Add(e);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var e = db.Products.FirstOrDefault(en => en.Id == id);
            db.Products.Remove(e);
            db.SaveChanges();
        }

        public void Edit(Product e)
        {
            var p = db.Products.FirstOrDefault(en => en.Id == e.Id);
            db.Entry(p).CurrentValues.SetValues(e);
            db.SaveChanges();
        }

        public List<Product> Get()
        {
           return db.Products.ToList();
        }

        public Product Get(int id)
        {
            return db.Products.FirstOrDefault(en => en.Id == id);
        }
    }
}
