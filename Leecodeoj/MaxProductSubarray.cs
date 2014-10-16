//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference> https://oj.leetcode.com/problems/maximum-product-subarray/ </reference>
//----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    public class MaxProductSubarray
    {
        public int FindMaxProduct(int[] array)
        {
            if (array.Length == 0)
                return 0;

            int currentMaxProduct = array[0];
            int currentMinProduct = array[0];
            int maxProduct = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    currentMaxProduct = Math.Max(currentMaxProduct * array[i], array[i]);
                    currentMinProduct = Math.Min(currentMinProduct * array[i], array[i]);
                }
                else
                {
                    int temp = currentMaxProduct;
                    currentMaxProduct = Math.Max(currentMinProduct * array[i], array[i]);
                    currentMinProduct = Math.Min(temp * array[i], array[i]);
                }
                maxProduct = Math.Max(maxProduct, currentMaxProduct);
            }
            return maxProduct;
        }
    }
}
