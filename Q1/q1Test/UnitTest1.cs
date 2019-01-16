using System;
using q1Classlib;
using Xunit;

namespace q1Test
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(10000, 12, 3, new double[] { 11200, 12544, 14049.28 })]

        public void TestSortByAlphabetical(double balance, int interestRate, int year, double[] expect)
        {
            var sut = new CalculateLoanInterest();
            var result = sut.CalculateInterestPerYear(balance, interestRate, year);
        
            for (int i = 0; i < year; i++)
            {
                Assert.Equal(expect, result);
            }
        }
    }
}
