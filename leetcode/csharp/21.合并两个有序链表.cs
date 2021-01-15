/*
 * @lc app=leetcode.cn id=21 lang=csharp
 *
 * [21] 合并两个有序链表
 */

// @lc code=start

/* 
模拟数据
    l1 = [1,2,4],l2=[1,3,4]
知识点：
    1. 线性表
    2. 线性表-链表存储 
    3. 递归
时间复杂度：O(m+n)    
空间复杂度：O(m+n)
运行
    1.  l1.1 < l2.1 
        run else 
        finally 
        return l2
        return l2.1
    2.  l1 =[1,2,4],l2=[3,4]
        l1.1  < l2.3
        run if
        finally 
        return l1
        return l1.1
    3. l1 =[2,4] ,12=[3,4]
        l1.2 < l2.3
        run if 
        finally 
        return l1;
        return l1.2;              
    4. l1 = [4] , l2=[3,4]
        l1.4 < l2.3
        run else
        finally
        return l2
        return l2.3
    5. l1 =[4] , l2= [4]
        l1.4 < l2.4
        return else
        finally
        return l2  
        return l2.4      
    6. l1 =[4] , 12 =[]
        l2 is null
        return l1
    7.  finally return 
        6 = l1.[4]
        5 = l2.[4]
        4 = l2.[3]
        3 = l1.[2]
        2 = l1.[1]
        1 = l2.[1]
        [l2.1,l1.1,l1.2,l2.3,l2.4,l1.4]
 */

namespace Solution21
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
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 is null)
                return l2;
            if (l2 is null)
                return l1;

            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }
    }
}

// @lc code=end
