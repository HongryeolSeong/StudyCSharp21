﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UsingEventApp
{
    class CustomNotifier
    {
        // 이벤트 선언, 사용하는 객체
        public event EventHandler SomethingHappened; // 대리자의 인스턴스 이벤트

        public void DoSometing(int number)
        {
            int temp = number % 10;

            if (temp != 0 && temp % 3 == 0) // 3, 6, 9로 떨어지는 값
            {
                SomethingHappened($"{number} : 짝!"); // 이벤트를 사용
            }
        }
    }
}
