/*
 * @lc app=leetcode.cn id=876 lang=csharp
 *
 * [876] 链表的中间结点
 */

// @lc code=start
/*  
知识点：
    1. 线性表
    2. 线性表-链表存储
    3. 双指针(快慢指针)
时间复杂度O(n)
空间复杂度O(1)
*/
namespace Solution876
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode MiddleNode(ListNode head)
        {
            if (head is null)
                return null;
            var slow = head;
            var fast = head;
            while (fast?.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            return slow;
        }
    }
}

// @lc code=end

