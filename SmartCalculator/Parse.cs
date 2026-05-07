using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SmartCalculator
{
    internal class Parser
    {

        public static Parser Instance = new Parser();

        private Stack<double> numbers= new Stack<double>();
        private Stack<char> operators= new Stack<char>();
       

        public double DistributionAndParseValuseWithAnswer(string answer)
        {
            numbers.Clear();
            operators.Clear();

            for (int i = 0; i < answer.Length; i++)
            {
                char item = answer[i];

               
                if (char.IsDigit(item))
                {
                    string numberStr = "";
                    
                    while (i < answer.Length && (char.IsDigit(answer[i]) || answer[i] == ','))
                    {
                        numberStr += answer[i];
                        i++;
                    }
                    i--; 

                    if (double.TryParse(numberStr, out double val))
                        numbers.Push(val);
                }
               
                else if (item.IsOperator())
                {
                    Auto(item);
                }
            }

           
            while (operators.Count > 0) MathOperation.Solving(numbers, operators);

            return numbers.Pop();
        }


           
        

        private int GetPriority(char op)
        {
            if (op == '*' || op == '/') return 2;
            if (op == '+' || op == '-') return 1;
            if (op == '^') return 3;
            return 0;
        }

        private void Auto(char op)
        {
            while(operators.Count > 0 && GetPriority(operators.Peek()) >= GetPriority(op)) MathOperation.Solving(numbers, operators);

            operators.Push(op);
        }
       

    }
}
