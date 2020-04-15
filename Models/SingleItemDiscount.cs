using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyDoKoszyka.Models
{
    public class SingleItemDiscount
    {
        public string Name { get; set; }
        public int RequiredQuantity { get; set; }
        public decimal Discount { get; set; }
        public SingleItemDiscount(string productName, int requiredQuantity, decimal discount)
        {
            Name = productName;
            RequiredQuantity = requiredQuantity;
            Discount = discount;
        }
    }
}
