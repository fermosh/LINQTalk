using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTalk
{
    public class ClockDisplay
    {
        public ClockDisplay( Clock clock ) {
            clock.tick += Display;
        }
        public void Display(TimeChangedEventArgs args) {
            Console.WriteLine($"Time went from {args.HourFrom:D2}:{args.MinuteFrom:D2}:{args.SecondFrom:D2} to {args.HourTo:D2}:{args.MinuteTo:D2}:{args.SecondTo:D2}");
        }
    }
}
