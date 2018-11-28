using Product_API.Interface;
using Product_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_API.Service
{
    public class ProductService : IProductService
    {
        public Product Add(Product newItem)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllItems()
        {
            throw new NotImplementedException();
        }

        public Product GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
