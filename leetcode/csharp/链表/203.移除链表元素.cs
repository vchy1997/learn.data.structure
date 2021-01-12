/*
 * @lc app=leetcode.cn id=203 lang=csharp
 *
 * [203] 移除链表元素
 */

// @lc code=start
/* 
模拟数据 ：1->2->3->4->5->6, val = 3
知识点：
    1. 线性表
    2. 线性表-链表存储
    3. 哨兵
时间复杂度O(n)
空间复杂度O(1)
运行
    1.  sentinel = 0->1->2->3->4->5->6
        prev = 0->1->2->3->4->5->6
        curr = 1->2->3->4->5->6
        curr is not null
        run while
        curr.val != val
        prev = 1->2->3->4->5->6
        curr = 2->3->4->5->6
        sentinel = 0->1->2->3->4->5->6
    2.  curr is not null
        run while
        curr.val != val
        prev = 2->3->4->5->6
        curr = 3->4->5->6
        sentinel = 0->1->2->3->4->5->6
    3.  curr is not null
        run while
        curr.val == val
        prev = 2->4->5->6
        curr = 4->5->6
        sentinel = 0->1->2->4->5->6
    4......            
    
 */
namespace Solution203
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            if (head is null)
                return null;
            var sentinel = new ListNode(0);
            sentinel.next = head;
            var prev = sentinel;
            var curr = head;
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

