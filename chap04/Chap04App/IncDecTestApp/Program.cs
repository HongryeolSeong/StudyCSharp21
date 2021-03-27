using System;

namespace IncDecTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("증감연산자 테스트");

            int result = 26;
            Console.WriteLine($"현재 숫자는 {result}");
            result += 3;
            Console.WriteLine($"현재 숫자는 {result}");
            result -= 10;
            Console.WriteLine($"현재 숫자는 {result}");
            Console.WriteLine($"전치 증가 값은 {++result}"); // 20 전위 증감
            Console.WriteLine($"후치 증가 값은 {result++}"); // 후위 증감 21
            Console.WriteLine($"전치 감소 값은 {--result}"); // 20 실행전 1 감소
            Console.WriteLine($"후치 감소 값은 {result--}"); // 실행후 1 감소 19
            Console.WriteLine($"최종 값은 {result}");

        }
    }
}