using System;

namespace WinEquation
{
    class MyChar
    {  
        public static bool IsBinaryOperation(char c)
        {
            if(c == '+' || c == '-' || c == '*' || c == '/' || c == '^') return true;
            return false;
        }
    }
}
