using System;
using System.Text;

namespace StringBuilderApp
{
    class Program
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder("Hello World!\n");
            // sb[6] = 'N'; // 권장x
            sb.Append("My name is Hugo\n");
            sb.Append("I'm 47years old.\n"); // '가 특수문자지만 그냥 출력 가능
            sb.Append("Book price is 30,000 won.\n");
            sb.Insert(6, "New ");
            sb.Replace("Book", "시계");

            Console.WriteLine(sb);
        }
    }
}
