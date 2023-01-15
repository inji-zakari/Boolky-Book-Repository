using BulkyBook.Core.Models;
using BulkyBook.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.Repository.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext db) : base(db)
        {
            _context = db;
        }

        public void Update(Product product)
        {
            var obj = _context.Products.FirstOrDefault(x => x.Id == product.Id);
            if (obj != null)
            {
                obj.Title = product.Title;
                obj.ISBN = product.ISBN;
                obj.ListPrice = product.ListPrice;
                obj.Price = product.Price;
                obj.Author = product.Author;
                obj.CategoryId = product.CategoryId;
                obj.CoverTypeId = product.CoverTypeId;
                obj.Description = product.Description;
                obj.UpdateDate = product.UpdateDate;
                obj.Price100 = product.Price100;
                obj.Price50 = product.Price50;
                if (obj.ImageUrl != null)
                {
                    obj.ImageUrl = product.ImageUrl;
                }
            }
        }
    }
}
