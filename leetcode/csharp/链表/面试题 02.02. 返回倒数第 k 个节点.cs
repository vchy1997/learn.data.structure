/*
 * @lc app=leetcode.cn id=1290 lang=csharp
 *
 * [面试题 02.02]. 返回倒数第 k 个节点
 */

// @lc code=start
/* 
知识点:
    1. 线性表
    2. 线性表链表
    3. 双指针 - 快慢指针
时间复杂度:O(n)    
空间复杂度:O(1)
 */

namespace Solution面试题0202
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public int KthToLast(ListNode head, int k)
        {
            if(head is null)
                return -1;
            var slow = head;
            var fast = head;
            while (k-- > 0)
            {
                fast = fast.next;
            }
            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            return slow.val;
        }
    }
}



// @lc code=end

