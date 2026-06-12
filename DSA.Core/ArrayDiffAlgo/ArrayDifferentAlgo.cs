using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace DSA.Core.ArrayDiffAlgo
{
    public class ArrayDifferentAlgo
    {
        public static int[] ArrayDiff(int[] a, int[] b) // a = [1,2] , b = [1]
        {
            var result = new List<int>();
            foreach (var item in a)
            {
                if (!b.Contains(item))
                {
                    result.Add(item);
                }
            }
            return result.ToArray();
        }
    }
}
