﻿using System;
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
                var DiscountedProduct = cart.Products
                        .Where(p => p.Name == product.Name);
                _cost -= DiscountedProduct
                        .Count() >= product.RequiredQuantity ?
                         DiscountedProduct.Sum(p => p.Price) * (product.Discount / 100m) : 0;
                Console.WriteLine(DiscountedProduct.Count());
                Console.WriteLine("Produkt rabatujący: {0}, Req.qty: {1}",product.Name,product.RequiredQuantity);
            }
            return cart.Products
                .GroupBy(p => p.Category)
                .Distinct()
                .Count() >= 3 ?
                _cost * 0.9m : _cost;
        }
        //foreach discount
        // if (x.Count(x=>x.Name==discount.SzukanaNazwa))>=discount.ilosc 

    }
}
