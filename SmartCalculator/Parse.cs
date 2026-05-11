using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq.Expressions;
using System.Text;

namespace SmartCalculator
{
    internal class Parser
    {

        public static Parser Instance = new Parser();

        private Stack<double> numbers= new Stack<double>();
        private Stack<char> operators= new Stack<char>();
       

        
        
             public double Parse(string expression)
        {
            numbers.Clear();
            operators.Clear();
            expression = expression.Replace(" ", "").Replace(".", ","); 

            for (int i = 0; i < expression.Length; i++)
            {
                char item = expression[i];

                
                if (char.IsDigit(item) || (item == '-' && IsUnary(expression, i)))
                {
                    string numberStr = item.ToString();
                    i++;
                    while (i < expression.Length && (char.IsDigit(expression[i]) || expression[i] == ','))
                    {
                        numberStr += expression[i];
                        i++;
                    }
                    i--;
                    if (double.TryParse(numberStr, out double val)) numbers.Push(val);
                }
                
                else if (item == '(')
                {
                    operators.Push(item);
                }
               
                else if (item == ')')
                {
                    while (operators.Count > 0 && operators.Peek() != '(')
                        MathOperation.Solving(numbers, operators);
                    operators.Pop(); 
                }
               
                else if (IsOperator(item))
                {
                    while (operators.Count > 0 && GetPriority(operators.Peek()) >= GetPriority(item))
                        MathOperation.Solving(numbers, operators);
                    operators.Push(item);
                }
            }

            while (operators.Count > 0) MathOperation.Solving(numbers, operators);
            return numbers.Pop();
        }

        private bool IsUnary(string expr, int index)
        {
           
            if (index == 0) return true;
            char prev = expr[index - 1];
            return IsOperator(prev) || prev == '(';
        }

        private bool IsOperator(char c) => "+-*/^".Contains(c);

        private int GetPriority(char op)
        {
            if (op == '^') return 3;
            if (op == '*' || op == '/') return 2;
            if (op == '+' || op == '-') return 1;
            return 0;
        }


    }
}
