using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp
{
    class Menu
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------\a");
            Console.WriteLine("0. 주소 입력\a");
            Console.WriteLine("1. 주소 검색\a");
            Console.WriteLine("2. 주소 수정\a");
            Console.WriteLine("3. 주소 삭제\a");
            Console.WriteLine("4. 주소 전체 출력\a");
            Console.WriteLine("5. 프로그램 종료\a");
            Console.WriteLine("-------------------\a");
            Console.Write("메뉴를 선택하세요 >>> ");
            string CKI = Console.ReadLine();

            Profile profile = new Profile();
          
            switch (CKI)
            {
                case "0":
                    Console.WriteLine("이름 입력 : ");
                    string Name = Console.ReadLine();
                    profile.Name = Name;
                    Console.WriteLine("전화 입력 : \a");
                    string Pnum = Console.ReadLine();
                    profile.Pnum = Pnum;
                    Console.WriteLine("주소 입력 : \a");
                    string Addr = Console.ReadLine();
                    profile.Addr = Addr;
                    break;
                case "1":
                    Console.WriteLine("이름 입력 : ");
                    string a1 = Console.ReadLine();
                    a1 = profile.Name;
                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    break;
                default:
                    Console.WriteLine("다시 입력하세요.");
                    break;
            }
        }
    }
}
