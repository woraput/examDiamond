
using System.Collections.Generic;

public interface ICalculateLoanInterest
{
    double[] CalculateInterestPerYear(double balance, int interestRate, int year);
}