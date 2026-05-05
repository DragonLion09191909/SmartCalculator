using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SmartCalculator
{
    internal class Parser
    {

        public static Parser Instance = new Parser();

        private List<char> numbers= new List<char>();
        private List<char> operators= new List<char>();
       

        public  void Parse(string answer)
        {
            foreach(var item in answer)
            {
                if (char.IsNumber(item))
                {
                    numbers.Add(item);
                }
                if (ExtensionMethods.IsOperator(item))
                {
                    operators.Add(item);
                }

               
                
            }
        }


    }
}
