using StoreDAL.BMs;
using StoreDAL.Is;
using StoreDAL.VMs;
using StoreModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreServices.Services
{
    public class ProductService : IProductService
    {
        private StoreDbContext context;

        public ProductService(StoreDbContext context)
        {
            this.context = context;
        }

        public void Add(ProductBM model)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть");
            }
            context.Products.Add(new Product
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
                Count = model.Count,
            });
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Products.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public ProductVM Get(int id)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new ProductVM
                {
                    Id = element.Id,
                    Name = element.Name,
                    CategoryId = element.Category.Id,
                    Count = element.Count,
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<ProductVM> GetList()
        {
            List<ProductVM> result = context.Products.Select(rec => new ProductVM
            {
                Id = rec.Id,
                Name = rec.Name,
                CategoryId = rec.Category.Id,
                Count = rec.Count,
            })
            .ToList();
            return result;
        }

        public void Update(ProductBM model)
        {
            Product element = context.Products.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть");
            }
            element = context.Products.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Name = model.Name;
            element.CategoryId = model.CategoryId;
            element.Count = model.Count;
            context.SaveChanges();
        }
    }
}
