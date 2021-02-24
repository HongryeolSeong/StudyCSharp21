using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticTestApp
{
    class TestClass
    {
        public static int number;
        public float fnum;

        public static float ProcSomething()
        {
            Console.WriteLine($"{number}, 뭔가를 한다.");
            return 1.0f;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            TestClass aCls = new TestClass();
            TestClass.number = 10; // static 활용하면 한 번만 10을 할당해도 결과는 같음
            aCls.fnum = 3.25f;

            TestClass bcls = new TestClass();
            bcls.fnum = 4.87f;

            TestClass.ProcSomething(); // static 활용하면 한 번만 메소드 호출해도 결과는 같음
        }
    }
}
