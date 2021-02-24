using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcTestApp
{
    // 여러 행위(기능 : 메소드)들이 많다
    class Mathz
    {
        public int Plus(int a, int b)
        {
            // ...
            return 1;
        }

        public void PrintEven(int val)
        {
            if (val % 2 == 0)
            {
                Console.WriteLine($"값: {val}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // 앞에 작업 있다고 가정

            Mathz mathz = new Mathz();

            int x;

            // ~~~ 작업

            x = 6;
            /*if (x % 2 == 0)
            {
                Console.WriteLine($"x의 값: {x}");
            }*/
            mathz.PrintEven(x);

            // ~~~~~~~~~~~~~

            x = 10;
            /*if (x % 2 == 0)
            {
                Console.WriteLine($"x의 값: {x}");
            }*/
            mathz.PrintEven(x);



            // 작업 있다고 가정
        }
    }
}