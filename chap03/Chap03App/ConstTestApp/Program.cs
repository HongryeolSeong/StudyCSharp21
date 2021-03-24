using System;

namespace ConstTestApp
{
    class Program
    {
        enum Season // 열거
        {   // 디폴트 말고 원하는 값 지정 가능
            Spring,
            Summer,
            Fall,
            Winter
        }

        static void Main(string[] args)
        {
            Console.WriteLine("상수테스트");
            const double PI = 3.141592; // float과 달리 f안써도됨
            Console.WriteLine($"원주율의 값은 {PI}");
            // PI = 6.345; // PI가 상수라 불가


            Season mySeaon = (Season) 0;
            Console.WriteLine($"지금 계절은 {mySeaon}입니다."); // 값은 0이지만 문자로 출력

            int a = 0;
            Console.WriteLine($"a는 {a}");
            int? b = null; // Nullable
            Console.WriteLine($"b는 {b}");
        }
    }
}