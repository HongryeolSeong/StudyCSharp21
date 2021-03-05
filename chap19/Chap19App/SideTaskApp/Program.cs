using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SideTaskApp
{
    class SideTask
    {
        int Count { get; set; }
        public SideTask(int count)
        {
            this.Count = count;
        }

        public void CountDown()
        {
            try
            {
                while (Count > 0)
                {
                    
                    Console.WriteLine($"{Thread.CurrentThread.ManagedThreadId} : {Count} 남음");
                    Count--;
                    Thread.Sleep(10);
                }
                Console.WriteLine($"Count : {Count}"); // 0
            }
            catch (ThreadAbortException ex)
            {
                Console.WriteLine($"스레드 임의종료 예외 발생 : {ex.Message}");
                // Thread.ResetAbort(); // 잘안됨
            }
            catch (Exception ex)
            {
                Console.WriteLine($"스레드 예외 발생 : {ex.Message}");
            }
            
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            SideTask task = new SideTask(100);
            Thread th = new Thread(task.CountDown);
            th.IsBackground = false; // th 스레드가 메인 스레드에 포함 x --> th가 종료되기 전까지 프로세스가 끝나지 않음

            SideTask task2 = new SideTask(100);
            Thread th2 = new Thread(task2.CountDown);

            Console.WriteLine("스레드 시작!");
            th.Start();
            th2.Start();

            Thread.Sleep(100);

            Console.WriteLine("인터럽트!");
            th2.Interrupt();
            /*Console.WriteLine("임의 종료!");
            th.Abort();*/

            Console.WriteLine("종료 대기"); // 카운트다운 중간에 표시
            th.Join();
            th2.Join();

            Console.WriteLine("스레드/프로세스 종료!");
        }
    }
}
