using System;
using System.Collections.Generic;
using System.Linq;
using q2Api.Models;

namespace q2Api.Controllers

{
    public class POS : IPOS
    {
        public static List<Cart> cart = new List<Cart>{};

        public double sumPriceOfProductInCart()
        {
            var result = 0.0;
            var select = cart.Select(it => it.Balance).ToList();
            foreach (var item in select)
            {
                result += item;
            }
            return result;
        }
    }
}
