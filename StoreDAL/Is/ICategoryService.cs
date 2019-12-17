using StoreDAL.BMs;
using StoreDAL.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Is
{
    public interface ICategoryService
    {
        void Add(CategoryBM model);

        CategoryVM Get(int id);

        List<CategoryVM> GetList();

        void Update(CategoryBM model);

        void Delete(int id);

        void Copy(int id);
	}
}
