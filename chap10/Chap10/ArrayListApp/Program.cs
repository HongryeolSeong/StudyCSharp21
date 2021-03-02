using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList array = new ArrayList(new[] { 80, 74, 81, 90, 34 });
            Console.WriteLine("81위치에 50추가");
            var loc = array.IndexOf(81);
            array.Insert(loc, 50);

            foreach (var item in array)
            {
                Console.WriteLine($" {item}");

            }

            // 90 지우기
            Console.WriteLine("90삭제");
            array.RemoveAt(4);
            foreach (var item in array)
            {
                Console.WriteLine($" {item}");

            }

            Console.WriteLine("정렬");
            array.Sort();
            foreach (var item in array)
            {
                Console.WriteLine($" {item}");

            }
        }
    }
}
