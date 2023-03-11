using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDBContext _db;

        public ProductRepository(ApplicationDBContext db) :base(db)
        {
            _db = db;
        }
       

        void IProductRepository.Update(Product obj)
        {
            var data = _db.Products.FirstOrDefault(u=>u.Id==obj.Id);
            if(data!=null)
            {
                data.Title = obj.Title;
                data.ISBN = obj.ISBN;
                data.Price = obj.Price;
                data.Price50 = obj.Price50;
                data.Price100 = obj.Price100;
                data.ListPrice = obj.ListPrice;
                data.Description = obj.Description;
                data.CategoryId = obj.CategoryId;
                data.Author = obj.Author;
                data.CoverTypeId = obj.CoverTypeId;
                if (obj.ImageUrl != null)
                {
                    data.ImageUrl = obj.ImageUrl;
                }
            }
           
        }
    }
}
