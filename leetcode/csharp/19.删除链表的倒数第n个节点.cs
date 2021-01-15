/*
 * @lc app=leetcode.cn id=19 lang=csharp
 *
 * [19] 删除链表的倒数第N个节点
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
namespace Solution19
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head is null)
                return head;
            var slow = head;
            var fast = head.next;
            while (n-- > 0)
            {
                fast = fast?.next;
            }
            while (fast != null)
            {
                fast = fast.next;
                slow = slow.next;
            }
            slow.next = slow?.next?.next;
            return head;
        }
    }
}

// @lc code=end

