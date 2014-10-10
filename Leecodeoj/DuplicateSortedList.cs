//-----------------------------------------------------------------------
// <author>Pajace Chen</author>
// <email>pajace@gmail.com</email>
// <Reference>https://oj.leetcode.com/problems/remove-duplicates-from-sorted-list/</reference>
//----------------------------------------------------------------------

//  Given a sorted linked list, delete all duplicates such that each element appear only once.
//  
//  For example,
//  Given 1->1->2, return 1->2.
//  Given 1->1->2->3->3, return 1->2->3.


using Leecodeoj.Common;
using System;
namespace Leecodeoj
{
    /// <summary>
    /// Remove Duplicates from Sorted List
    /// </summary>
    public class DuplicateSortedList
    {
        /// <summary>
        /// Remove Duplicates from Sorted List
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public Common.ListNode removeDuplicates(Common.ListNode head)
        {
            ListNode node = head;
            ListNode nextNode = null;

            while (node != null)
            {
                nextNode = node.next;
                if (nextNode == null)
                    node = node.next;
                else if (node.val == nextNode.val)
                    node.next = nextNode.next;
                else
                    node = node.next;
            }

            return head;
        }
    }
}
