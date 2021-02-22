using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntConversionApp
{
    class ConvTest
    {
        static void Main(string[] args)
        {
            short shMaxVal = short.MaxValue;
            int inCastVal = 0;
            inCastVal = shMaxVal;
            Console.WriteLine($"short값 변환한 int값은 {inCastVal}");

            inCastVal += 5; // 32767 + 5 = 32772
            short shCaStVal = (short) inCastVal;
            // short shCaStVal = inCastVal; // 안들어감
            Console.WriteLine($"int값 변환한 short값은 {shCaStVal}"); // Overflow

            float flVal = 3.141592F; // F : 나는 플롯값이다
            inCastVal = (int) flVal;
            Console.WriteLine($"float값 변환한 int값은 {inCastVal}");
            double dlVal = inCastVal; // 3
            Console.WriteLine($"int값 변환한 double값은 {inCastVal}");

            object obj = 20; // Boxing
            int inUnboxingVal = (int) obj; // Unboxing
            Console.WriteLine($"언박싱값은 {obj}");

            string strVal = "200";
            // int result = strVal * 3; // 문자열과 숫자여서 연산 불가
            int result = int.Parse(strVal) * 3; // 문자열을 숫자로 형변환
            Console.WriteLine($"200 * 3 = {result}");
        }
    }
}
