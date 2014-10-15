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
            if (array.Length == 1)
                return array[0];

            int maxProduct = 0;
            for (int i = 1; i < array.Length; i++)
            {
                int product = array[i];
                if (product > maxProduct)
                    maxProduct = product;
                if (array[i - 1] == 0)
                    product = array[i];
                else
                    product = array[i - 1] * array[i];

                if (product > maxProduct)
                    maxProduct = product;
            }
            return maxProduct;
        }
    }
}
