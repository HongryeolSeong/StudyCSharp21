using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessModifierTestApp
{
    class Boiler
    {
        internal int temp = 5; // 물 온도

        public void SetTemp(int temp)
        {
            if (temp < 30 || temp > 60)
            {
                Console.WriteLine("물의 온도가 일정 온도를 벗어났습니다. 59℃로 셋팅합니다~");
                this.temp = 59;
            }
            else
            {
                this.temp = temp;
            }
        }

        public int GetTemp()
        {
            return this.temp;
        }

        public void TurnOnBoiler()
        {
            Console.WriteLine("보일러를 켭니다.");
        }
        
        public void TurnOffBoiler()
        {
            Console.WriteLine("보일러를 끕니다.");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Boiler kitturami = new Boiler();
            var currTemp = kitturami.GetTemp();
            Console.WriteLine($"현재 온도는 {currTemp}℃ 입니다.");
            kitturami.SetTemp(40);
            kitturami.TurnOnBoiler();
            kitturami.SetTemp(59);
            kitturami.SetTemp(36);

            if (kitturami.GetTemp() >= 59)
            {
                kitturami.TurnOffBoiler();
            }
            /*kitturami.TurnOnBoiler();
            kitturami.TurnOffBoiler();*/
        }
    }
}