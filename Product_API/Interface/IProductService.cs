using Product_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_API.Interface
{
    public interface IProductService
    {
        IEnumerable<Product> GetAllItems();
        Product Add(Product newItem);
        Product GetById(Guid id);
        void Remove(Guid id);
    }
}
