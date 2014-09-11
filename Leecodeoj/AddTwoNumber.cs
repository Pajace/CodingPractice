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
            ListNode result = null;
            ListNode headNode = null;
            int? carryDigit = null;


            while (l1 != null || l2 != null || carryDigit != null)
            {

                if (l1 == null && l2 == null)
                {
                    result.next = new ListNode((int)carryDigit);
                    break;
                }

                int sum = ((l1 == null) ? 0 : l1.val) + ((l2 == null) ? 0 : l2.val);
                int digitValue = sum % 10;

                if (result == null && carryDigit == null)
                {
                    result = new ListNode(digitValue);
                    headNode = result;
                }
                else if (carryDigit != null)
                {
                    int nodeValue = (digitValue + (int)carryDigit) % 10;
                    result.next = new ListNode(nodeValue);
                    result = result.next;
                }
                else
                {
                    result.next = new ListNode(digitValue);
                    result = result.next;
                }

                if (carryDigit != null && digitValue + carryDigit >= 10)
                    carryDigit = (digitValue + carryDigit) / 10;
                else
                    carryDigit = ((sum / 10 == 0) ? (int?)null : (sum / 10));

                l1 = (l1 == null) ? null : l1.next;
                l2 = (l2 == null) ? null : l2.next;
            }

            return headNode;
        }
    }
}
