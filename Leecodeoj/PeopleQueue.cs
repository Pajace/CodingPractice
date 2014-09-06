//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
//----------------------------------------------------------------------

using System;
using System.Collections.Generic;
namespace Leecodeoj
{
    /// <summary>
    /// 問題描述：
    ///      有 totalPerson 個人在排隊，從第 startPerson 開始（含），每隔 interval 取一人，共取 countOfSelected 個人
    ///      若遇到最後一個則接著第一個往下數
    ///      例如：有10個人排隊 1, 2, 3, 4, 5, 6, 7, 8, 9, 10
    ///            從第 2 個人開始, 每個 4 人取一個, 共取 5 位
    ///            則選取到的人為  [2, 6, 10, 5, 1]
    /// </summary>
    public class PeopleQueue
    {
        /// <summary>
        /// 排隊問題
        /// </summary>
        /// <param name="totalPerson">排隊總人數</param>
        /// <param name="startPerson">開始位置</param>
        /// <param name="interval">間隔人數</param>
        /// <param name="countOfSelected">總共選取人數</param>
        /// <returns></returns>
        public static int[] Select(int totalPerson, int startPerson, int interval, int countOfSelected)
        {
            List<int> personList = new List<int>();
            int[] selectedPerson = new int[countOfSelected];

            for (int i = 0; i < totalPerson; i++)
                personList.Add((i + 1));

            int selectedIndex = startPerson - 1;
            for (int i = 0; i < countOfSelected; i++)
            {
                selectedPerson[i] = personList[selectedIndex];

                personList.RemoveAt(selectedIndex);
                selectedIndex--;

                selectedIndex += interval;
                selectedIndex %= personList.Count;
            }

            return selectedPerson;
        }
    }
}
