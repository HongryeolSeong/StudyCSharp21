using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class MyBase { }
    class MyClass : MyBase { }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass c = new MyClass();
            new Program().Test(c);
            Console.WriteLine(c);
        }

        public void Test(object obj)
        {
            // as 연산자
            MyBase a = obj as MyBase;

            // is 연산자
            bool ok = obj is MyBase; //true

            // Explicit Casting
            MyBase b = (MyBase)obj;
        }
    }
}
