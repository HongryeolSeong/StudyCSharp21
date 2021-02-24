﻿using System;

namespace OverLoadTestApp
{
    class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("계산기~~!");

            int x = Calculator.Plus(3, 4);
            Console.WriteLine($"3 + 4 = {x}");

            float y = Calculator.Plus(3.14f, 5.6f);
            Console.WriteLine($"3.14 + 5.6 = {y}");

            Console.WriteLine($"3.14 + 5.6 = {Calculator.Plus(3.14, 5.6)}");

            Console.WriteLine($"3.14 + 5 = {Calculator.Plus(3.14, "5")}");

            int z = Calculator.Plus(7, 8, 9);
            Console.WriteLine($"7 + 8 + 9 = {z}");

            int total = 0;
            total = Sum(1, 2, 4, 6, 8, 56);

            Console.WriteLine($"합계는 {total}");

            Console.WriteLine($"10까지의 합은 {Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10)}");

            int[] arrs = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine($"10까지의 합은 {Sum(arrs)}");
        }

        private static int Sum(params int[] args) // 가변길이 매개변수
        {
            int result = 0;

            foreach (var arg in args)
            {
                result += arg;
            }
            return result;
        }

        private static int Plus(int v1, int v2, int v3)
        {
            int result = v1 + v2 + v3;
            return result;
        }

        private static object Plus(double v1, string v2)
        {
            double.TryParse(v2, out double p2);
            double result = v1 + p2;
            return result;
        }

        private static double Plus(double v1, double v2) // 17라인에서 변수형이 확인이 안되어 object로 자동 설정됨.
        {
            double result = v1 + v2;
            return result;
        }

        private static float Plus(float v1, float v2)
        {
            float result = v1 + v2;
            return result;
        }

        private static int Plus(int v1, int v2)
        {
            int result = v1 + v2;
            return result;
        }
    }
}