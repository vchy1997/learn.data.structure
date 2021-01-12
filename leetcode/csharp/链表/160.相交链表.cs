/*
 * @lc app=leetcode.cn id=160 lang=csharp
 *
 * [160] 相交链表
 */

namespace Solution160
{
    // @lc code=start
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            var curr1 = headA;
            var curr2 = headB;
            while (curr1 != curr2)
            {
                curr1 = curr1?.next ?? headB;
                curr2 = curr2?.next ?? headA;
            }
            return curr1;
        }
    }
}


// @lc code=end

