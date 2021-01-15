/*
 * @lc app=leetcode.cn id=1290 lang=csharp
 *
 * [剑指 Offer 52]. 两个链表的第一个公共节点
 */

// @lc code=start
/* 
知识点： 
   1. 线性表
   2. 线性表-链表存储
   3. 双指针
时间复杂度：O(n)    
空间复杂度：O(1)  
 */

namespace Solution剑指Offer52
{
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
            if (headA is null || headB is null)
                return null;
            var curr1 = headA;
            var curr2 = headB;
            while (curr1 != curr2)
            {
                curr1 = curr1 == null ? headB : curr1.next;
                curr2 = curr2 == null ? headA : curr2.next;
            }
            return curr1;
        }
    }
}



// @lc code=end

