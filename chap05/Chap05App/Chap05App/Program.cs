using System;

namespace Chap05App
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("수를 입력하세요 : ");
                string line = Console.ReadLine(); // 콘솔에서 입력 값(문자열)을 변수 할당

                if (line == "quit") break; // quit 입력시 앱 종료

                int number = 0;
                int.TryParse(line, out number); // TryParse : 숫자이외 입력시 0반환 // 입력 값, 출력 값 지정
                // int.Parse(line); -> 문자입력시 오류
                Console.WriteLine(number);


                // todo 아래로직을 수정하세요~
                if (number > 0)
                {
                    if (number % 2 == 0)
                        Console.WriteLine("0 보다 큰 짝수");
                    else
                        Console.WriteLine("0 보다 큰 홀수");
                }
                else if (number == 0)
                {
                    Console.WriteLine("0 입니다.");
                }
                else
                {
                    Console.WriteLine("0 보다 작은 수");
                }
                // todo 마지막
            }

            Console.WriteLine("계산종료~~");
        }
    }
}
