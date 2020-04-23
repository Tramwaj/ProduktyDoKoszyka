using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyDoKoszyka.Models
{
    public static class CostCalculator
    {
        public static decimal Cost(this Cart cart)
        {
            return cart.Products.Sum(x => x.Price);
        }

        public static decimal CostAfterDiscount(this Cart cart, DiscountsService discounts)
        {
            decimal _cost = cart.Cost();
            foreach (var product in discounts.singleItemDiscounts)
            {
                var DisountedProducts = cart.Products
                        .Where(p => p.Name == product.Name);
                _cost -= DisountedProducts
                        .Count() >= product.RequiredQuantity ?
                         DisountedProducts.Sum(p => p.Price) * (product.Discount / 100m) : 0;
            }
            return cart.Products
                .GroupBy(p => p.Category)
                .Distinct()
                .Count() >= 3 ?
                _cost * 0.9m : _cost;
        }        
    }
}
