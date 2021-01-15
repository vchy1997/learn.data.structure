/*
 * @lc app=leetcode.cn id=160 lang=csharp
 *
 * [160] 相交链表
 */
// @lc code=start
/* 
模拟数据 
   A:[4,4,5]
   B:[5,6,4,5]
知识点： 
   1. 线性表
   2. 线性表-链表存储
   3. 双指针
时间复杂度：O(m+n)    
空间复杂度：O(1)     
运行:
A[1] == B[2]
| cuur1   | curr2   |
|---------|---------|
| A[0]    | B[0]    |
| A[1]    | B[1]    |
| A[2]    | B[2]    |
| A[NULL] | B[3]    |
| B[0]    | B[NULL] |
| B[1]    | A[0]    |
| B[2]    | A[1]    |
 */

namespace Solution160
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

