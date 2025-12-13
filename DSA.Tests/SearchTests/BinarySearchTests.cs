using DSA.Core.SearchAlgo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Tests.SearchTests
{
    public class BinarySearchTests
    {
        [Fact]
        public void testNull()
        {
            int[]? array = null;
            int index = BinarySearch.Search(array, 10);
            Assert.Equal(-1, index);
        }
        [Fact] 
        public void testEmpty()
        {
            int[] array = { };
            int index = BinarySearch.Search(array, 10);
            Assert.Equal(-1, index);
        }
        [Fact]
        public void testSingleElement()
        {
            int[] array = { 10 };
            int index = BinarySearch.Search(array, 10);
            Assert.Equal(0, index);
        }
        [Fact]
        public void testBoundaryCase()
        {
            int[] array = { 10, 11 , 28 ,29 , 49 , 50};
            int index = BinarySearch.Search(array, 11);
            Assert.Equal(1, index);
            index = BinarySearch.Search(array, 10);
            Assert.Equal(0, index);
            index = BinarySearch.Search(array, 29);
            Assert.Equal(3, index);
        }
        [Fact]
        public void testUnHappyCase()
        {
            int[] array = { 10, 11, 28, 39, 49, 50 };
            int index = BinarySearch.Search(array, 29);
            Assert.Equal(-1, index);
            index = BinarySearch.Search(array, 51);
            Assert.Equal(-1, index);
            index = BinarySearch.Search(array, 9);
            Assert.Equal(-1, index);
        }
    }
}
