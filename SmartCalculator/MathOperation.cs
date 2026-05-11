using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCalculator
{
    internal class MathOperation
    {
        public static void Solving(Stack<double> numbers, Stack<char> operators)
        {
            if (operators.Count == 0 || operators.Peek() == '(') return;

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
                case '^': result = Math.Pow(left, right); break;
            }
            numbers.Push(result);

        }
    }
}

    

