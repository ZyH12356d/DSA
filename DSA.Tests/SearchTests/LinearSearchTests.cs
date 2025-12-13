using DSA.Core.SortingAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.SortingTests
{
    public class LinearSearchTests
    {
        [Fact]
        public void testEmpty()
        {
            int[] array = { };
            int index = LinearSearch.Search(array, 10);
            Assert.Equal(-1, index);
        }
        [Fact]
        public void testNull()
        {
            int[]? array = null;
            int index = LinearSearch.Search(array, 10);
            Assert.Equal(-1, index);
        }
        [Fact]
        public void testSingleElement()
        {
            int[] array = {10};
            int index = LinearSearch.Search(array, 10);
            Assert.Equal(0, index);
        }
        [Fact]
        public void testBoundaryCase()
        {
            int[] array = {10 , 11};
            int index = LinearSearch.Search(array, 11);
            Assert.Equal(1, index);
            
            index = LinearSearch.Search(array, 10);
            Assert.Equal(0, index);
        }
        [Fact]
        public void testUnHappyCase()
        {
            int[] array = {10 , 11};
            int index = LinearSearch.Search(array, 12);
            Assert.Equal(-1, index);
            
        }
        [Fact]
        public void testDuplicateCase()
        {
            int[] array = {10 , 11 , 19 , 21 , 30 , 11 , 19};
            int index = LinearSearch.Search(array, 19);
            Assert.Equal(2, index);
            
        }

    }
}
