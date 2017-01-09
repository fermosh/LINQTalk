using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace LINQTalk
{
    public class Clock
    {
        public delegate void SecondChangedEventHandler(TimeChangedEventArgs args);

        public  SecondChangedEventHandler tick = null;
        private int hour;
        private int minute;
        private int second;

        public Clock() {
            hour = 0;
            minute = 0;
            second = 0;
        }

        public void Run() {
            while (true){
                Thread.Sleep(100);
                var now = DateTime.Now;
                if (now.Second != second) {
                    TimeChangedEventArgs eventArgs = new TimeChangedEventArgs { HourFrom = hour, MinuteFrom = minute, SecondFrom = second, HourTo = now.Hour, MinuteTo = now.Minute , SecondTo = now.Second };
                    tick?.Invoke(eventArgs);
                    hour = now.Hour;
                    minute = now.Minute;
                    second = now.Second;

                }

            }
        }
    }
    
}
