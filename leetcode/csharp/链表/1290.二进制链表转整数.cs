/*
 * @lc app=leetcode.cn id=1290 lang=csharp
 *
 * [1290] 二进制链表转整数
 */

// @lc code=start
/* 
知识点:
    1. 线性表
    2. 线性表链表
    3. 进制转换
时间复杂度:O(n)    
空间复杂度:O(1)
 */

namespace Solution1290
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public int GetDecimalValue(ListNode head)
        {
            var ams = 0;
            var curr = head;
            while (curr != null)
            {
                ams = ams * 2 + curr.val;
                curr = curr.next;
            }
            return ams;
        }
    }
}



// @lc code=end

