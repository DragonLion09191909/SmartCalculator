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

        public string Use()
        {
            string answer = Console.ReadLine();
            double result=Parser.Instance.Parse(answer);
            return result.ToString();
            

        }
        







    }
}
