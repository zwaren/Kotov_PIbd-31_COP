using StoreDAL.BMs;
using StoreDAL.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreDAL.Is
{
    public interface IProductService
    {
        void Add(ProductBM model);

        ProductVM Get(int id);

        List<ProductVM> GetList();

        void Update(ProductBM model);

        void Delete(int id);
    }
}
