/*
 * @lc app=leetcode.cn id=83 lang=csharp
 *
 * [83] 删除排序链表中的重复元素
 */

// @lc code=start
/* 
模拟数据
    [1,1,1,2,2]
知识点：
    1. 线性表
    2. 线性表-链表存储 
    3. 递归
时间复杂度：O(n)    
空间复杂度：O(n)
运行
    1. curr =1 next = [2]:1
        run 1 == 1
        return next [2]:1
    
    2. curr = 1 next =[2]:1
        run 1 == 1
        return next [2]:1

    3. curr =1  next =[3]:2
        run 1 == 2 
        return next [2]:1

    4. curr=2 next=[4]:2      
        run 2 == 2 
        return next [4]:2
    5. curr=2 next= null
        run 2 == null
        return next [4]:2
    6. finally return         
        5 = [2]
        4 = [2]
        3 = [1,2]
        2 = [1,2]
        1 = [1,2]
        [[2]1,[4]2]        
 */
namespace Solution83
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
        public ListNode DeleteDuplicates(ListNode head)
        {
            if (head is null)
                return null;
            head.next = DeleteDuplicates(head.next);
            return head.val == head.next?.val ? head.next : head;
        }
    }
}

// @lc code=end

