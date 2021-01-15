/*
 * @lc app=leetcode.cn id=234 lang=csharp
 *
 * [234] 回文链表
 */

// @lc code=start

/* 
知识点：
    1. 线性表
    2. 线性表-链表存储
    3. 递归
时间复杂度O(n)
空间复杂度O(n)
 */

namespace Solution234
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        ListNode Lift = null;
        public bool IsPalindrome(ListNode head)
        {
            Lift = head;
            return Check(head);
        }

        public bool Check(ListNode head)
        {
            if (head is null)
                return true;
            var check = Check(head.next) && Lift.val == head.val;
            Lift = Lift.next;
            return check;
        }
    }
}

// @lc code=end

