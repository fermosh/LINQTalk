using System;

namespace LINQTalk
{
    public class TimeChangedEventArgs : EventArgs
    {
        public int HourFrom { get; set; }
        public int MinuteFrom { get; set; }
        public int SecondFrom { get; set; }
        public int HourTo { get; set; }
        public int MinuteTo { get; set; }
        public int SecondTo { get; set; }
    }
}