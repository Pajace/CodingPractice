//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/remove-duplicates-from-sorted-array/</reference>
//----------------------------------------------------------------------

namespace Leecodeoj
{
    public class RemoveDuplication
    {
        /// <summary>
        /// Given a sorted array, remove the duplicates in place such that each element appear only once and return the new length.
        /// Do not allocate extra space for another array, you must do this in place with constant memory.
        /// </summary>
        /// <param name="data">sorted arrry</param>
        /// <returns>The size of array that remove duplicate</returns>
        public int RemoveDuplicate(int[] data)
        {
            if (data.Length == 0) return 0;

            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[index] != data[i])
                {
                    index++;
                    data[index] = data[i];
                }
            }
            return index+1;
        }
    }
}
