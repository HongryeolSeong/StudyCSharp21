using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewOverrideTestApp
{
    class Mammal { 
        public string Name { get; set; }

        public void Breathe() {
            Console.WriteLine($"{this.Name}이(가) 숨을 쉰다.");
        }

        public virtual void Move() {
            Console.WriteLine($"(부모 작업) {this.Name}이(가) 네발로 이동한다.");
        }
    }

    class Dog : Mammal {
        public override void Move() { // 부모의 메소드를 재정의
            base.Move(); // 부모에 있는 Move 실행
            Console.WriteLine($"{this.Name}이(가) 네발로 움직인다."); // + alpha 실행
        }
    }

    class Human : Mammal {
        public override void Move() {
            base.Move();
            Console.WriteLine($"{this.Name}이(가) 두발로 움직인다.");
        }
    }

    class Whale : Mammal {
        public new void Move() { // 부모의 메소드를 숨긴다.
            Console.WriteLine($"{this.Name}이(가) 헤엄쳐서 움직인다.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog ppoppi = new Dog();
            ppoppi.Name = "뽀삐";
            ppoppi.Move();

            Human mansigi = new Human();
            mansigi.Name = "만식";
            mansigi.Move();

            Whale whale = new Whale();
            whale.Name = "고래";
            whale.Move();
        }
    }
}
