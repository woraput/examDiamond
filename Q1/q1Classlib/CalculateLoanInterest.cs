using System;
using System.Collections.Generic;
using q1Classlib.Models;

namespace q1Classlib
{

    public class CalculateLoanInterest : ICalculateLoanInterest
    {
        public List<LoanInterest> loanInterest = new List<LoanInterest> { };
        public List<LoanInterest> CalculateInterestPerYear(LoanInterest model)
        {
            var interest = 0.0;
            var totalBalance = 0.0;
            var listBalance = new List<double>();

            for (int i = 0; i < model.Year; i++)
            {
                interest = (model.Balance * model.InterestRate) / 100;
                model.TotalBalance = model.Balance + model.Interest;
                loanInterest.Add(model);
            }

            var result = listBalance.ToArray();
            return loanInterest;
        }
    }
}
