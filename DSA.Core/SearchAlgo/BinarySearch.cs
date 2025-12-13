using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Core.SearchAlgo
{
    public class BinarySearch
    {
        public static int Search(int[] arr, int target)
        {
            if(arr == null)
            {
                return -1; // Handle null
            }
            int left = 0;
            int right = arr.Length - 1;
            while (left <= right)
            {
                int mid = left + (right - left) / 2;
                if (arr[mid] == target)
                {
                    return mid; // Target found
                }
                else if (arr[mid] < target)
                {
                    left = mid + 1; // Search in the right half
                }
                else
                {
                    right = mid - 1; // Search in the left half
                }
            }
            return -1; // Target not found
        }
    }
}
