using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyDoKoszyka.Models
{
    public class ProductGroup 
    {
        public string Name { get; set; }
        public int ItemsCount { get; set; }
        public decimal Value { get; set; }
        public ProductCategory Category { get; set; }
    }
    public class Cart
    {
        public List<Product> Products { get; set; }
        public IList<ProductGroup> ProductGroups
        {//value
            get => Products.GroupBy(
                p => p.Name,
                (name, price) => new ProductGroup
                {
                    Name = name,
                    ItemsCount = price.Count(),
                    Value = price.Sum(p => p.Price)
                })
                .ToList();
        }
        //public decimal TotalCost 
        //{
        //    get => Products.Sum(x => x.Price); 
        //}
        public int ItemsCount
        {
            get => Products.Count();
        }
        public Cart()
        {
            Products = new List<Product>();
        }
        public void AddProduct(Product _product)
        {
            Products.Add(_product);
        }
        public int ProductsCount()
        {
            return Products.Count();
        }

    }
}
