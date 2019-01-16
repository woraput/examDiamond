using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using q2Api.Models;

namespace q2Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class POSController : ControllerBase
    {

        public static List<Products> products = new List<Products>{
            new Products{Id = 1, Name = "ลูกอม", Price = 5},
            new Products{Id = 2, Name = "เลย์", Price = 20},
            new Products{Id = 3, Name = "แฮม", Price = 50},
        };

        public static List<Cart> cart = new List<Cart>
        {
            new Cart{Id = 1, Name = "ลูกอม", NumberOf = 3, Price = 5, Balance = 15},
        };

        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Products>> Get()
        {
            return products.ToList();
        }

        [HttpGet("[action]")]
        public ActionResult<IEnumerable<Cart>> GetCart()
        {
            return cart.ToList();
        }

        [HttpPost("[action]")]
        public void AddProduct([FromBody]Products model)
        {
            var id = products.Max(it => it.Id) + 1;
            model.Id = id;
            products.Add(model);
        }

        [HttpPost("[action]")]
        public void AddProductToCart([FromBody]Cart model)
        {
            var id = cart.Max(it => it.Id) + 1;
            model.Id = id;
            model.Balance = model.NumberOf * model.Price;
            cart.Add(model);
        }

        [HttpGet("[action]")]
        public double SumPrice()
        {
            var result = 0.0;
            var select = cart.Select(it => it.Balance).ToList();
            foreach (var item in select)
            {
                result += item;
            }

            return result;
        }

        [HttpGet("[action]")]
        public double SumOfDiscount()
        {
            var carts = cart.ToList();
            var sumDiscount = 0.0;
            foreach (var item in carts)
            {
                var discount = item.NumberOf / 3;
                sumDiscount += discount * item.Price;
            }

            return sumDiscount;
        }
    }
}
