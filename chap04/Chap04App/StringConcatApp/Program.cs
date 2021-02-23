using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringConcatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("숫자 더하기");
            var p2 = 456;
            Console.WriteLine(123 + p2); // 579 산술 연산자 +
            Console.WriteLine("123" + 456); // 123456 문자열 결합 연산자 +
            Console.WriteLine($"123{456}");// C# 6.0이후 문자열 만드는 방법
            Console.WriteLine("123" + "456"); // 123456 문자열 결합 연산자 +

            // 관계연산자
            int a = 30, b = 30;
            Console.WriteLine(a < b);
            Console.WriteLine(a > b);
            Console.WriteLine(a <= b);
            Console.WriteLine(a >= b);
            Console.WriteLine(a == b);
            Console.WriteLine(a != b);

            // 논리연산자
            Console.WriteLine("논리연산자");
            Console.WriteLine(10 > 9 && a > 0);
            Console.WriteLine(a > b || b > 0);
            Console.WriteLine(!(a < b));

            // 조건(삼항)연산자 단항 if문 대체 가능
            int c = 30;
            string result = c == 30 ? "삼십" : "삼십아님";
            /* if (c == 30)
                result = "삽십";
            else
                result = "삼십아님"; */

            Console.WriteLine(result);

            // 널 병합 연산자
            int? d = null;
            Console.WriteLine($"{d ?? 0}"); // d가 null이면 0을 출력
        }
    }
}