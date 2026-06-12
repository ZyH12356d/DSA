using DSA.Core.ArrayDiffAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.ArrayDifferentTests
{
    public class ArrayDiffTests
    {
        ArrayDifferentAlgo _arrDiff = new();
        [Fact]
        public void BasicTests()
        {
                Assert.Equal(new int[] { 2 }, ArrayDifferentAlgo.ArrayDiff(new int[] { 1, 2 }, new int[] { 1 }));
                Assert.Equal(new int[] { 2, 2 }, ArrayDifferentAlgo.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 1 }));
                Assert.Equal(new int[] { 1 }, ArrayDifferentAlgo.ArrayDiff(new int[] { 1, 2, 2 }, new int[] { 2 }));
                Assert.Equal(new int[] { 3 }, ArrayDifferentAlgo.ArrayDiff(new int[] { 1, 2, 3 }, new int[] { 1, 2 }));
        }
    }
}
