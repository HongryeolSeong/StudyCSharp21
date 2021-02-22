using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // 문자
            char ch1 = 'T', ch2 = '\t', ch3 = '\n', ch4 = '0';
            Console.WriteLine($"{ch1}, {ch2}, {ch3}, {ch4}");
            char ch5 = '\\';
            Console.WriteLine($"{ch5}");

            // 문자열
            string str1 = "\"Hello, \aWorld!\""; // \a : 알림음
            Console.WriteLine($"{str1}");

            // boolean
            bool isTrue = true; // true
            if (isTrue)
            {
                Console.WriteLine("참입니다");
            }
            else
            {
                Console.WriteLine("거짓입니다");
            }
            Console.WriteLine(isTrue); // 소스에는 소문자이지만 출력시 앞글자가 대문자로 출력
        }
    }
}