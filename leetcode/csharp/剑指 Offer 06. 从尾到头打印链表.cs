/*
 * @lc app=leetcode.cn id=1290 lang=csharp
 *
 * [剑指 Offer 06]. 从尾到头打印链表
 */

// @lc code=start
/* 
知识点:
    1. 线性表
    2. 线性表链表
    3. 递归
时间复杂度:O(n)    
空间复杂度:O(n)
 */

namespace Solution剑指Offer06
{
    using System.Collections.Generic;
    using System.Linq;
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        IList<int> _result = new List<int>();
        public int[] ReversePrint(ListNode head)
        {
            if (head != null)
                Reverse(head);
            return _result.ToArray();
        }

        public void Reverse(ListNode head)
        {
            if (head.next != null)
                Reverse(head.next);
            _result.Add(head.val);
        }
    }
}



// @lc code=end

