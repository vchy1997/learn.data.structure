/*
 * @lc app=leetcode.cn id=237 lang=csharp
 *
 * [237] 删除链表中的节点
 */

// @lc code=start
/*  
知识点：
    1. 线性表
    2. 线性表-链表存储
时间复杂度O(1)
空间复杂度O(1)
*/

namespace Solution237
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    public class Solution
    {
        public void DeleteNode(ListNode node)
        {
            if (node is null)
                return;
            node.val = node.next.val;
            node.next = node.next.next;
        }
    }
}

// @lc code=end

