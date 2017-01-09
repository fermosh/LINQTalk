using LINQTalk;
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var clock = new Clock();
        var clockDisplay = new ClockDisplay(clock);
        var primeAlert = new PrimeSecondAlerter(clock);
        clock.Run();
    }

}