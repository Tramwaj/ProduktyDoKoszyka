using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyDoKoszyka.Models
{
    class Cart
    {
        public List<Product> Products { get; set; }
        public decimal TotalCost 
        {
            get => Products.Sum(x => x.Price); 
        }
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

    }
}
