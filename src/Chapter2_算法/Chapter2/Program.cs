using System;

namespace Chapter2
{
    class Program
    {
        static void Main(string[] args)
        {
            var algo =new Algo();            
            algo.Algo1();
        }
    }

    class Algo
    {
        //求等差数列算法
        public void Algo1()
        {
             var n=100;
             var result = (n+1)*n/2;
            WriteConsole("求1+2+3+..+99+100的合","求等差数列计算",$"结果:{result}");

        }

        private void WriteConsole(params object[] objs)
        {
            Console.WriteLine("========================================");
            for (int i = 0; i < objs?.Length; i++)
            {
                Console.WriteLine(objs[i]);
            }
            Console.WriteLine("========================================");

        }
    }
}
