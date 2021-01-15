/*
 * @lc app=leetcode.cn id=1290 lang=csharp
 *
 * [剑指 Offer 18]. 删除链表的节点
 */

// @lc code=start
/* 
知识点:
    1. 线性表
    2. 线性表链表
    3. 哨兵
时间复杂度:O(n)    
空间复杂度:O(1)
 */

namespace Solution剑指Offer18
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {

        public ListNode DeleteNode(ListNode head, int val)
        {
            var sentinel = new ListNode(-1);
            sentinel.next = head;
            var curr = head;
            var prev = sentinel;
            while (curr != null)
            {
                if (curr.val == val)
                {
                    prev.next = curr.next;
                }
                else
                {
                    prev = curr;
                }
                curr = curr.next;
            }
            return sentinel.next;
        }
    }
}



// @lc code=end

