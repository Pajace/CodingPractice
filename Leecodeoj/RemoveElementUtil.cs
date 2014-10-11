using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    public class RemoveElementUtil
    {
        public int removeElement(int[] data, int elem)
        {
            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[index] == elem && data[i] != elem)
                {
                    data[index] = data[i];
                    index++;
                    data[i] = elem;
                }
                else if (data[index] != elem && data[i] != elem)
                {
                    index++;
                }
            }
            return index;
        }
    }
}
