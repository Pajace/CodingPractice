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
        public ListNode addTwoNumbers2(Common.ListNode l1, Common.ListNode l2)
        {
            ListNode dummy = new ListNode(0);
            ListNode node = dummy;

            int digitInTens = 0;

            while (l1 != null || l2 != null || digitInTens != 0)
            {
                int sum = getSumOfNodesValue(l1, l2) + digitInTens;
                int digitInOnes = getDigitInOnes(sum);

                digitInTens = getDigitInTens(sum);
                node.next = new ListNode(digitInOnes);

                node = node.next;
                l1 = getNextNode(l1);
                l2 = getNextNode(l2);
            }

            return dummy.next;
        }


        public ListNode addTwoNumbers(Common.ListNode list1Node, Common.ListNode list2Node)
        {
            ListNode dummy = new ListNode(0);
            ListNode node = dummy;

            int digitInTens = 0;

            while (list1Node != null || list2Node != null || digitInTens != 0)
            {
                // 兩節點值相加並加上上一節點的近位值
                int sum = CalculateTwoNodeSum(list1Node, list2Node) + digitInTens;
                // 取得個位數
                int digitInOnes = GetDigitInOnes(sum);
                // 取得十位數
                digitInTens = GetDigitInTens(digitInTens, sum);
                // 將相加的個位數新增至相加結果的 LinkedList 
                node = AddSumToResultLinkedListNextNode(node, digitInOnes);
                node = GetNextNode(node);
                // 取得兩 linked list 的下一節點
                list1Node = GetNextNode(list1Node);
                list2Node = GetNextNode(list2Node);
            }

            return dummy.next;
        }


        private static ListNode GetNextNode(ListNode node)
        {
            // 取得下一個節點
            return (node == null) ? null : node.next;
        }

        private static ListNode AddSumToResultLinkedListNextNode(ListNode node, int digitInOnes)
        {
            // 將個位數新增到結果的 linked list 上
            node.next = new ListNode(digitInOnes);
            return node;
        }

        private static int GetDigitInTens(int digitInTens, int sum)
        {
            // 取得十位數
            return  sum / 10;
        }

        private static int GetDigitInOnes(int sum)
        {
            // 取得個位數
            return sum % 10;
        }

        private static int CalculateTwoNodeSum(Common.ListNode list1Node, Common.ListNode list2Node)
        {
            // 兩個 Linked list 節點相加
            int sum = GetListNodeValue(list1Node) + GetListNodeValue(list2Node);
            return sum;
        }

        private static int GetListNodeValue(ListNode node)
        {
            if (node != null)
                return node.val;
            return 0;
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
