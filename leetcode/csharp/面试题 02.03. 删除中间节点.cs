/*
 * @lc app=leetcode.cn id=1290 lang=csharp
 *
 * [面试题 02.03]. 返回倒数第 k 个节点
 */

// @lc code=start
/* 
知识点:
    1. 线性表
    2. 线性表链表
    3. 内存地址
 */

namespace Solution面试题0203
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
           node.val = node.next.val;
           node.next = node.next.next;
        }
    }
}



// @lc code=end

