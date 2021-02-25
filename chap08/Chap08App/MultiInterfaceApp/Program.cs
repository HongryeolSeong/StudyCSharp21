using System;

namespace MultiInterfaceApp
{
    interface IRunnable // 차 종류
    {
        void Run();
    }

    interface IFlyable // 비행기 종류
    {
        void Fly();
    }

    class DroneCar : IRunnable, IFlyable
    {
        public void Fly()
        {
            Console.WriteLine("날아!");
        }

        public void Run()
        {
            Console.WriteLine("달려!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("드론카!");

            DroneCar dreamCar = new DroneCar();
            dreamCar.Run();
            dreamCar.Fly();

            Console.WriteLine("자동차로 변경(interface)");
            IRunnable car = dreamCar;
            car.Run();

            Console.WriteLine("배행기로 변경(interface)");
            IFlyable plane = dreamCar;
            plane.Fly();
        }
    }
}
