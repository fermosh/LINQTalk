using System;
using System.Collections.Generic;
using System.Text;

namespace LINQTalk
{
    public class PrimeSecondAlerter
    {
        public PrimeSecondAlerter(Clock clock) {
            clock.tick += EvaluateSecond;
        }
        private void EvaluateSecond(TimeChangedEventArgs args) {
            if (IsPrime(args.SecondTo)) {
                Console.WriteLine($"Second ({args.SecondTo}) is prime!");
            }
        }

        private bool IsPrime(int number) {
            if (number <= 1) return false;
            if (number <= 3) return true;
            for (var i = 2; i <= Math.Sqrt(number); i++) {
                if (number % i == 0) return false;
            }
            return true;
        }
    }
}
