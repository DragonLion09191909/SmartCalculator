using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCalculator
{
    public class SCalc<T>
    {
       
        static SCalc()
        {
            Console.WriteLine("Welcome! What operations do you want me to complete?");
            WaitingForAnswer();
           
        }

        private static void WaitingForAnswer()
        {
          string answerOfUser=Console.ReadLine();
          Solving(answerOfUser);
        }

        private T Solving(string answer)
        {

        }

        

        

        
    }
}
