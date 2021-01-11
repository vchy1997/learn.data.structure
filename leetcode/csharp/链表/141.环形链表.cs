/*
 * @lc app=leetcode.cn id=141 lang=csharp
 *
 * [141] 环形链表
 */

// @lc code=start
/* 
模拟数据
   head = [3,2,0,-4] , post = 1
   说明,则从数组下标1处开始为一个环形数组
知识点：
    1. 线性表
    2. 线性表-链表存储
    3. 快慢指针
时间复杂度：O(n)    
空间复杂度：O(1)    
运行
    1. head?.next != null
    2.  slow = [0]:3
        fast = [1]:2
        if slow != fast
        run while
        slow != null && fast !=null
        run setting
        slow = [1]:2
        fast = [3]:-4
    3.  if slow != fast
        run while
        slow !=null && fast !=null
        run setting
        post = 1
        slow = [2]:0
        fast = [2]:0 
    4.  if slow == fast
        return true                     

 */

namespace Solution141
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            if (head?.next is null)
                return false;
            var slow = head;
            var fast = head.next;
            while(slow!=fast)
            {
                if(slow is null || fast is null)
                    return false;
                slow = slow?.next;
                fast = fast?.next?.next;
            }
            return true;   
        }
    }
}
// @lc code=end

