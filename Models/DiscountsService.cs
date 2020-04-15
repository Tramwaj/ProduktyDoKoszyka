using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProduktyDoKoszyka.Models
{
    public class DiscountsService
    {
        public IReadOnlyList<SingleItemDiscount> singleItemDiscounts => new[]
        {
            new SingleItemDiscount("Silicone Baking Mat",2,10m),
            new SingleItemDiscount("Mind & Body Candle",3,15m)
        };
    }
}
