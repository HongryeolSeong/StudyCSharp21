using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericCopyArrayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] source = { 11, 21, 33, 45, 56 };
            int[] target = new int[source.Length];

            CopyArray(source, target); // int 배열 복사
            Console.WriteLine("배열 복사");
            foreach (var item in target)
            {
                Console.WriteLine(item);
            }

            string[] source2 = { "하나", "둘", "셋", "넷", "다섯", "여섯" };
            string[] target2 = new string[source2.Length];
            CopyArray(source2, target2);
            Console.WriteLine("string 배열 복사");
            foreach (var item in target2)
            {
                Console.WriteLine(item);
            }
        }

        //데이터 형식을 일반화한 메소드 Generic
        private static void CopyArray<T>(T[] source, T[] target)
        {
            for (int i = 0; i < source.Length; i++)
            {
                target[i] = source[i];
            }
        }
    }
}
