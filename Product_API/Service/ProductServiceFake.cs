using Product_API.Interface;
using Product_API.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Product_API.Service
{
    public class ProductServiceFake : IProductService
    {

        private readonly List<Product> _Product;

        public ProductServiceFake()
        {
            _Product = new List<Product>()
            {
                new Product() { Id = new Guid("ab2bd817-98cd-4cf3-a80a-53ea0cd9c200"),
                    Name = "Orange Juice", Manufacturer="Orange Tree", Price = 5.00M },
                new Product() { Id = new Guid("815accac-fd5b-478a-a9d6-f171a2f6ae7f"),
                    Name = "Diary Milk", Manufacturer="Cow", Price = 4.00M },
                new Product() { Id = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad"),
                    Name = "Frozen Pizza", Manufacturer="Uncle Mickey", Price = 12.00M }
            };
        }

        public IEnumerable<Product> GetAllItems()
        {
            return _Product;
        }

        public Product Add(Product newItem)
        {
            newItem.Id = Guid.NewGuid();
            _Product.Add(newItem);
            return newItem;
        }

        public Product GetById(Guid id)
        {
            return _Product.Where(a => a.Id == id)
                .FirstOrDefault();
        }

        public void Remove(Guid id)
        {
            var existing = _Product.First(a => a.Id == id);
            _Product.Remove(existing);
        }
    }
}
