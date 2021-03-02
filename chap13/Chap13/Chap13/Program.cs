using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap13
{
    delegate int MyDelegate(int a, int b); // 대리자. 대신 호출한다. 

    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }

        public int Minus(int a, int b)
        {
            return a - b;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc = new Calculator();

            // var result = calc.Plus(3, 4);
            //Console.WriteLine($"result = {result}"); // 일반적인 호출

            MyDelegate Callback;
            Callback = new MyDelegate(calc.Plus); // calc.Plus 메소드를 대신 호출
            Console.WriteLine($"result = {Callback(3, 4)}");

            Callback = new MyDelegate(calc.Minus);
            Console.WriteLine($"result = {Callback(5, 2)}");
        }
    }
}
