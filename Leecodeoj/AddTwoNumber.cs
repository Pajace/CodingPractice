//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/add-two-numbers/</reference>
//----------------------------------------------------------------------

// You are given two linked lists representing two non-negative numbers. 
// The digits are stored in reverse order and each of their nodes contain a
// single digit. Add the two numbers and return it as a linked list.
//
// Input: (2 -> 4 -> 3) + (5 -> 6 -> 4)
// Output: 7 -> 0 -> 8

using Leecodeoj.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Leecodeoj
{
    /// <summary>
    /// Add Two Number
    /// </summary>
    public class AddTwoNumber
    {
        /// <summary>
        /// AddTwoNumber
        /// </summary>
        /// <param name="root1"> non-negative numbers list node 1</param>
        /// <param name="root2"> non-negative numbers list node 2</param>
        /// <returns></returns>
        public ListNode addTwoNumbers(Common.ListNode l1, Common.ListNode l2)
        {

            ListNode node = null;
            ListNode headNode = null;

            int sum = getSumOfNodesValue(l1, l2);
            int digitInOnes = getDigitInOnes(sum);
            int digitInTens = getDigitInTens(sum);

            node = new ListNode(digitInOnes);
            headNode = node;
            l1 = getNextNode(l1);
            l2 = getNextNode(l2);

            while (l1 != null || l2 != null || digitInTens != 0)
            {

                if (l1 == null && l2 == null)
                {
                    node.next = new ListNode(digitInTens);
                    break;
                }

                sum = getSumOfNodesValue(l1, l2) + digitInTens;

                digitInOnes = getDigitInOnes(sum);
                digitInTens = getDigitInTens(sum);
                node.next = new ListNode(digitInOnes);

                node = node.next;
                l1 = getNextNode(l1);
                l2 = getNextNode(l2);
            }

            return headNode;
        }

        private static int getDigitInTens(int sum)
        {
            return (sum / 10);
        }

        private static int getDigitInOnes(int numbers)
        {
            return numbers % 10;
        }

        private static ListNode getNextNode(ListNode node)
        {
            return (node == null) ? null : node.next;
        }

        private static int getSumOfNodesValue(ListNode l1, ListNode l2)
        {
            return ((l1 == null) ? 0 : l1.val) + ((l2 == null) ? 0 : l2.val);
        }
    }
}
