using System;
using System.Collections;

namespace HashTableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("HashTalbe 예제");

            Hashtable ht = new Hashtable();
            ht["일"] = "one";
            ht["이"] = "two";
            ht["삼"] = "three";
            ht["사"] = "four";

            Console.WriteLine(ht["일"]);
            Console.WriteLine(ht["이"]);
            Console.WriteLine(ht["삼"]);
            Console.WriteLine(ht["사"]);

            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine($"{item.Key} : {item.Value}"); // 순서가 랜덤 -> 키값이 있기때문에 정렬 x
            }

            // 여러가지 초기화 방법
            int[] arr = { 123, 456, 789 };
            ArrayList list = new ArrayList(arr);
            ArrayList List2 = new ArrayList(new int[] { 123, 456, 789 });
            ArrayList List3 = new ArrayList() { 123, 456, 789 };
        }
    }
}
