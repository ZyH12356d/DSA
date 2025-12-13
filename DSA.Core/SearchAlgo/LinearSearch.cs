using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Core.SortingAlgo
{
    public class LinearSearch
    {
        public static int Search(int[]? arr , int num)
        {
            if (arr == null || arr.Length == 0)
            {
                return -1;
            }
            else
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] == num)
                    {
                        return i;
                    }
                }
                return -1;
            }
        }
    }
}
