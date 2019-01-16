using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using q1Api.Models;
using q1Classlib;

namespace q1Api.Controllers
{
    [Route("api/[controller]")]

    public class CalculateController : Controller
    {
        [HttpGet("{balance}/{interestRate}/{year}")]
        public double[] Calculator(double balance, int interestRate, int year)
        {
            var q1 = new CalculateLoanInterest();
            var result = q1.CalculateInterestPerYear(balance, interestRate, year);
            return result;
        }
    }
}
