/*
 * @lc app=leetcode.cn id=206 lang=csharp
 *
 * [206] 反转链表
 */

// @lc code=start
/* 
知识点： 
   1. 线性表
   2. 线性表-链表存储
   3. 递归
时间复杂度：O(n)    
空间复杂度：O(n)  
 */

namespace Solution206
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            if (head is null || head.next is null)
                return head;
            var result = ReverseList(head.next);
            head.next.next = head;
            head.next = null;
            return result;
        }
    }
}

// @lc code=end

