using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 47, y = 5;
            Console.WriteLine($"before Swap {x}, {y}");

            Program.Swap(/*ref*/ x,/*ref*/ y); // 정렬기반

            Console.WriteLine($"After Swap {x}, {y}");
        }

        // ref로 참조에 의한 매개변수 전달

        private static void Swap(/*ref*/ int p1,/*ref*/ int p2)
        {
            int temp = p1;
            p1 = p2;
            p2 = temp;
        }
    }
}