using System;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var node = new Solution19.ListNode(1);
            var r = new Solution19.Solution().RemoveNthFromEnd(node,1);
            Console.WriteLine("Hello World!");
        }      
    }
}
