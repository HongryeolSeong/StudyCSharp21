using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritTestApp
{
    class Parent
    {
        protected string Name;

        public Parent(string Name)
        {
            this.Name = Name;
            Console.WriteLine($"{this.Name} Parent() 생성자");
        }

        public void ParentMethod()
        {
            //...
            Console.WriteLine($"{this.Name}.ParentMethod() 실행");
        }

        /*~ Parent()
        {
            Console.WriteLine($"{this.Name}.parent() 소멸자"); 이제 안씀
        }*/
    }

    class Child : Parent
    {
        public string Color;

        public Child(string Name) : base(Name) // 부모 먼저 생성
        {
            Console.WriteLine($"{this.Name}.Child() 생성자");
        }

        public void ChildMethod()
        {
            Console.WriteLine($"{this.Name}.ChildMethod() 실행");
        }
        /*~Child()
        {
            Console.WriteLine($"{this.Name}.Child() 소멸자");
        }*/
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Parent p = new Parent("부모");
            p.ParentMethod();
            

            Child c = new Child("자식");
            c.Color = "파란색";
            c.ParentMethod();
            c.ChildMethod();
        }
    }
}