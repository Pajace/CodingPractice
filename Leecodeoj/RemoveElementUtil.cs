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
            if (data.Length == 1)
            {
                if (data[0] == elem)
                    return 0;
                return 1;
            }

            int index = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[index] == elem)
                {
                    if (data[i] != elem)
                    {
                        data[index] = data[i];
                        index++;
                        data[i] = elem;
                    }
                }
                else
                {
                    index++;
                }
            }
            return index;
        }
    }
}
