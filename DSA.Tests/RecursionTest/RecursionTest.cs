using DSA.Core.Recursion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.RecursionTest
{
    public class RecursionTest
    {
        [Fact]
        public void FactorialTest() 
        {
            var result = Recursion.Factorial(5);
            Assert.Equal(120, result);
            var result2 = Recursion.Factorial(0);
            Assert.Equal(1, result2);
            var result3 = Recursion.Factorial(1);
            Assert.Equal(1, result3);
        }
        [Fact]
        public void getDigitSumTest() 
        {
            var result = Recursion.getDigitSum(123);
            Assert.Equal(6, result);
            var result2 = Recursion.getDigitSum(0);
            Assert.Equal(0, result2);
            var result3 = Recursion.getDigitSum(9);
            Assert.Equal(9, result3);
        }
    }

}
