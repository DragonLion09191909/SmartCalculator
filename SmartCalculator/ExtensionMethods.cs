using System;
using System.Collections.Generic;
using System.Text;

namespace SmartCalculator
{
    internal static class ExtensionMethods
    {
        public static bool IsOperator(this char chr)
        {
            return chr == '-' || chr == '+' || chr == '/' || chr == '*' ? true : false;
        }
    }
}
