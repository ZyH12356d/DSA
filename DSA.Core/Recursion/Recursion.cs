using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Core.Recursion
{
    public class Recursion
    {
        public static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }
        public static int getDigitSum(int i)
        {
            if (i < 10)
                return i;
            return (i % 10) + getDigitSum(i / 10);
        }
    }
}
