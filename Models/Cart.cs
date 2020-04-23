using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyDoKoszyka.Models
{
    public class Cart
    {
        public List<Product> Products { get; set; }

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
