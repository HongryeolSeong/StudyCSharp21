using System;

namespace UsingEventApp
{
    delegate void EventHandler(string message); // 메시지 받아서 처리하는 대리자 선언

    class Program
    {
        /// <summary>
        /// 이벤트가 발생했을 때 실행되는 메소드(이벤트 핸들러)
        /// </summary>
        /// <param name="message"></param>
        public static void MyHandler(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("이벤트 핸들러 사용!");
            CustomNotifier notifier = new CustomNotifier(); // notifier는 이벤트의 조건이 발생되는지 항상 감시
            notifier.SomethingHappened += new EventHandler(MyHandler);

            for (int i = 1; i < 100; i++)
            {
                notifier.DoSometing(i);
            }
        }
    }
}
