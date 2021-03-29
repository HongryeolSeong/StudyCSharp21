using System;

namespace Chap07App
{
    class ObjectTest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Cat cat1 = new Cat(Name: "야옹이", Color: "흰색", "남자"); // 생성과 동시에 초기화
            cat1.Meow();
            /*//Cat cat1 = new Cat(); // 고양이 객체의 실체(instance) 생성
            //cat1.Name = "Navi";
            //cat1.Color = "흰색";
            

            Cat Kiity = new Cat();
            Kiity.Name = "헬로키티";
            Kiity.Color = "하얀색";
            Kiity.Meow();

            Cat Nero = new Cat();
            Kiity.Name = "검은고양이 네로";
            Kiity.Color = "검은색";
            Kiity.Meow();*/

            Cat yomi = new Cat("요미", "흰색", "암컷");
            yomi.Meow();
        }
    }

    class Cat
    {
        public Cat() { } // 사용자 지정 생성자 사용시 기본 생성자 꼭 만들어야함

        // ~Cat() { } // C#에서는 더 이상 필요 없음

        public Cat(string Name)
        {
            this.Name = Name;
        }

        public Cat(string Name, string Color) : this(Name)// 사용자 지정 생성자 : 생성과 동시에 초기화 위해
        {
            this.Color = Color;
        }

        public Cat(string Name, string Color, string Gender) : this(Name, Color)
        {
            this.Gender = Gender;
        }

        public string Name; // 이름
        public string Color; // 색상
        public string Gender; // 성별

        public void Meow()
        {
            Console.WriteLine($"{this.Name}(색상 : {this.Color} / 성별 : {this.Gender}) : Meow~");
        }
    }
}