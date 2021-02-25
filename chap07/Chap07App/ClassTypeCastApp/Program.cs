using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTypeCastApp
{
    class 포유류
    {
        public void 키우다()
        {
            Console.WriteLine("키우다()");
        }
    }

    class 강아지 : 포유류
    {
        public void 멍멍()
        {
            Console.WriteLine("멍멍!");
        }
    }

    class 고양이 : 포유류
    {
        public void 야옹()
        {
            Console.WriteLine("야옹~");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            포유류 _포유류 = new 포유류();
            _포유류.키우다();
            if (_포유류 is 포유류)
            {
                Console.WriteLine("지금은 포유류입니다.");
            }
            else
            {
                Console.WriteLine("지금은 포유류가 아닙니다.");
            }

            _포유류 = new 강아지(); // 자식 -> 부모로 형식 변환
            _포유류.키우다();

            강아지 쭈쭈;
            if (_포유류 is 강아지)
            {
                쭈쭈 = _포유류 as 강아지;
                쭈쭈.멍멍();
            }

            강아지 뽀삐 = null;
            if (뽀삐 is 포유류)
            {
                Console.WriteLine("이 부분이 실행 됩니다.");
                뽀삐 = new 포유류() as 강아지;
                뽀삐.키우다();
                뽀삐.멍멍();
            }
            else
            {
                Console.WriteLine("실행 실패");
            }
        }
    }
}