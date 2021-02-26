using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chap10
{
    class Test
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 80, 74, 81, 90, 34 }; //= new int[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }


            Console.WriteLine("크기 변경 후");
            Array.Resize(ref array, 6);

            Console.WriteLine("81 인덱스 찾기");
            int idx = Array.IndexOf(array, 81);
            for (int i = array.Length - 1; i > idx; i--)
            {
                array[i] = array[i - 1];
                //Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            array[idx] = 50;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            } // 배열은 이럴 때 무식한 작업이 너무 많다...

            /*Console.WriteLine($"Type of array : {array.GetType()}");
            Console.WriteLine($"Base Type of array : {array.GetType().BaseType}");

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }*/

            /*var idx = 0;
            foreach (var item in array)
            {
                Console.WriteLine($"{idx++}번째 값 : {item}");
            }*/

            /*Console.WriteLine("오름차순 정렬 후");
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            Console.WriteLine("내림차순 정렬 후");
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }

            int idx = Array.IndexOf(array, 74);
            Console.WriteLine($"74의 인덱스 : {idx}");

            idx = Array.IndexOf(array, 100);
            Console.WriteLine($"74의 인덱스 : {idx}"); // -1은 찾는 값이 없다는 뜻

            Console.WriteLine("배열 삭제 후");
            Array.Clear(array, 3, 2);
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i}번째 값 : {array[i]}");
            }*/
        }
    }
}
