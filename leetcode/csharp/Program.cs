using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Test206();
            Console.WriteLine("Hello World!");
        }

        static void Test206()
        {
            var node = new Solution206.ListNode(1);
            node.next = new Solution206.ListNode(2);
            node.next.next = new Solution206.ListNode(3);
            var r = new Solution206.Solution().ReverseList(node);
        }
    }
}
