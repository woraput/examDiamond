using System;
using System.Collections.Generic;

namespace q1Classlib
{
    public class CalculateLoanInterest : ICalculateLoanInterest
    {
        public double[] CalculateInterestPerYear(double balance, int interestRate, int year)
        {
            var interest = 0.0;
            var totalBalance = 0.0;
            var listBalance = new List<double>();

            for (int i = 0; i < year; i++)
            {
                interest = (balance * interestRate) / 100;
                totalBalance = balance + interest;
                balance = totalBalance;
                listBalance.Add(totalBalance);
            }

            var result = listBalance.ToArray();
            return result;
        }
    }
}
