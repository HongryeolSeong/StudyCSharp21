using System;

namespace LoggerTestApp
{
    interface ILogger
    {
        void WriteLog(string message);
    }

    class ConsoleLogger : ILogger // 구현
    {
        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now} : {message}");
        }
    }

    interface IFormattableLogger : ILogger // 구현이 아니라 상속
    {
        void WriteLog(string format, params object[] args);
    }

    class ConsoleFormatLogger : IFormattableLogger // 구현
    {
        public void WriteLog(string format, params object[] args)
        {
            string message = String.Format(format, args);
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }

        public void WriteLog(string message)
        {
            Console.WriteLine($"{DateTime.Now.ToLocalTime()} / {message}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ConsoleLogger 테스트!");
            ConsoleLogger logger = new ConsoleLogger();
            logger.WriteLog("로그 메시지");

            ConsoleFormatLogger logger2 = new ConsoleFormatLogger();
            logger2.WriteLog("{0} * {1} = {2}", 3, 4, 12);
        }
    }
}
