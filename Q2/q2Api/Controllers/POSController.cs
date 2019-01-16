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

    public class POSController : Controller
    {

        public static List<Products> products = new List<Products>{
            new Products{Id = 1, Name = "ลูกอม", Price = 5},
            new Products{Id = 2, Name = "เลย์", Price = 20},
            new Products{Id = 3, Name = "แฮม", Price = 50},

        };


        [HttpGet]
        public ActionResult<IEnumerable<Products>> Get()
        {
            return products.ToList();
        }

    
        [HttpPost]
        public void Post(Products model)
        {
            var id = products.Max(it => it.Id) + 1;
            model.Id = id;
            products.Add(model);
        }  
    }
}
