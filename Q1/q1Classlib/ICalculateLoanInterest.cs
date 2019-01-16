
using System.Collections.Generic;
using q1Classlib.Models;

public interface ICalculateLoanInterest
{
    List<LoanInterest> CalculateInterestPerYear(LoanInterest model);
}