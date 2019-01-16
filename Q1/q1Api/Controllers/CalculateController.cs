using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using q1Api.Models;
using q1Classlib;
using q1Classlib.Models;

namespace q1Api.Controllers
{
    [Route("api/[controller]")]

    public class CalculateController : Controller
    {
        public static List<LoanInterest> loanInterest = new List<LoanInterest> { };

        [HttpPost]
        public void Post(LoanInterest model)
        {
            var year = model.Year;
            var listBalance = new List<LoanInterest>();
            for (int i = 1; i <= year; i++)
            {
                model.Interest = model.Balance * model.InterestRate / 100;
                model.TotalBalance = model.Balance + model.Interest;
                model.Year = i;
                loanInterest.Add(new LoanInterest()
                {
                    InterestRate = model.InterestRate,
                    Balance = model.Balance,
                    Year = model.Year,
                    Interest = model.Interest,
                    TotalBalance = model.TotalBalance,
                });
                model.Balance = model.TotalBalance;
            }
        }

        [HttpGet]
        public List<LoanInterest> Get()
        {
            return loanInterest.ToList();

        }
    }
}
