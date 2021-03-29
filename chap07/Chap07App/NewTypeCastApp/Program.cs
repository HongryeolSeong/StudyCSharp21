using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypeCastApp
{
    class Mammal
    {
        public string Name { get; set; }
        public void Nurse()
        {
            Console.WriteLine($"{this.Name}을(를) 키우다");
        }
    }

    class Dog : Mammal
    {
        public void Bark()
        {
            Console.WriteLine($"{this.Name}, 멍멍!!");
        }
    }

    class Cat : Mammal
    {
        public void Meow()
        {
            Console.WriteLine($"{this.Name}, 야옹~");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Mammal mammal = new Mammal();
            mammal.Name = "포유류";
            mammal.Nurse();

            mammal = new Dog();

            Dog ppoppi = null;
            ppoppi.Name = "뽀삐";
            ppoppi.Nurse();
            ppoppi.Bark();

            /*Cat chichi = new Cat();
            chichi.Name = "치치";
            chichi.Nurse();
            chichi.Meow();*/

            /*if (ppoppi is Mammal)
            {
                // 값형식은 long = int값;
                Mammal mammal1 = ppoppi as Mammal; // 참조형식은 as를 써서 형변환 // 자식 -> 부모이어서 as Mamal 생략가능
                mammal1.Nurse();
                // mammal1.Bark(); // error
            }

            if (mammal is Dog)
            {
                ppoppi = mammal as Dog;
                ppoppi.Nurse();
                ppoppi.Bark();
            }*/
        }
    }
}
