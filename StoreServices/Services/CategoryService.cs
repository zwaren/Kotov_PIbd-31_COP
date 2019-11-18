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
    public class CategoryService : ICategoryService
    {
        private StoreDbContext context;

        public CategoryService(StoreDbContext context)
        {
            this.context = context;
        }

        public void Add(CategoryBM model)
        {
            Category element = context.Categories.FirstOrDefault(rec => rec.Name == model.Name);
            if (element != null)
            {
                throw new Exception("Уже есть");
            }
            context.Products.Add(new Product
            {
                Name = model.Name,
            });
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Category element = context.Categories.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                context.Categories.Remove(element);
                context.SaveChanges();
            }
            else
            {
                throw new Exception("Элемент не найден");
            }
        }

        public CategoryVM Get(int id)
        {
            Category element = context.Categories.FirstOrDefault(rec => rec.Id == id);
            if (element != null)
            {
                return new CategoryVM
                {
                    Id = element.Id,
                    Name = element.Name,
                };
            }
            throw new Exception("Элемент не найден");
        }

        public List<CategoryVM> GetList()
        {
            List<CategoryVM> result = context.Products.Select(rec => new CategoryVM
            {
                Id = rec.Id,
                Name = rec.Name,
            })
            .ToList();
            return result;
        }

        public void Update(CategoryBM model)
        {
            Category element = context.Categories.FirstOrDefault(rec => rec.Name == model.Name && rec.Id != model.Id);
            if (element != null)
            {
                throw new Exception("Уже есть");
            }
            element = context.Categories.FirstOrDefault(rec => rec.Id == model.Id);
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            element.Name = model.Name;
            context.SaveChanges();
        }
    }
}
