using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCalculator
{
    internal class MathOperation
    {
        public static void Solving(Stack<double> numbers, Stack<char> operators)
        {
            char op = operators.Pop();

            
            double right = numbers.Pop();
            double left = numbers.Pop();

            double result = 0;

           
            switch (op)
            {
                case '+': result = left + right; break;
                case '-': result = left - right; break;
                case '*': result = left * right; break;
                case '/': result = left / right; break;
                case '^':
                    result = right==0?1:left;
                    if (right != 0)
                    {
                        for (int i = 1; i < right; i++)
                        {

                            result *= left;
                        }
                    }
                    
                    break;
                    
                    
                   


            }

          
            numbers.Push(result);
        }
    }

    
}
