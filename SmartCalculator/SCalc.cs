using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;

namespace SmartCalculator
{
    internal class SCalc
    {
       
        static SCalc()
        {
            Console.WriteLine("Welcome! What operations do you want me to complete?");

        }

        public void Use()
        {
            string answer = Console.ReadLine();
            Parser.Instance.Parse(answer);

        }

        

        

        
    }
}
