using System;

namespace DelegateChainApp
{
    delegate void Allcalc(int x, int y); // 대리자 선언

    class Program
    {
        static void Plus(int a, int b) { Console.WriteLine($"a + b = {a + b}"); }
        static void Minus(int a, int b) { Console.WriteLine($"a - b = {a - b}"); }
        static void Multiple(int a, int b) { Console.WriteLine($"a * b = {a * b}"); }
        static void Divide(int a, int b) { Console.WriteLine($"a / b = {a / b}"); }
        static void Main(string[] args)
        {
            Console.WriteLine("Calculating~");
            /*Plus(10, 5);
            Minus(10, 5);
            Multiple(10, 5);
            Divide(10, 5);*/ // 일반 호출 방식

            Allcalc allcalc = Plus;
            allcalc += Minus;
            allcalc += Multiple;
            allcalc += Divide;
            allcalc(10, 5);

            Console.WriteLine("곱셈 메소드 제거");
            allcalc -= Multiple;
            allcalc(10, 5); // 다시 계산
        }
    }
}
