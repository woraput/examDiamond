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
            for (int i = 0; i < model.Year; i++)
            {
                model.Interest = (model.Balance * model.InterestRate) / 100;
                model.TotalBalance = model.Balance + model.Interest;
            }
                loanInterest.Add(model);

            return loanInterest;
        }
    }
}
