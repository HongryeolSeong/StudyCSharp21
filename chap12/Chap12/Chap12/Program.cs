using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap12
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, };
            for (int i = 0; i < 5; i++) // 예외 발생
            {
                Console.WriteLine($"{i} 번째 값 : {arr[i]}");
            }
        }
    }
}
