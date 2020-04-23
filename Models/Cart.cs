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
        public ProductCategory Category { get; set; }
    }
    public class Cart
    {
        public List<Product> Products { get; set; }
        
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
        public void Clear()
        {
            Products = new List<Product>();
        }

    }
}
