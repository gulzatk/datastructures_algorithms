using System;
using System.Collections.Generic;

namespace valid_parantheses_stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsValid("({})"));
            Console.WriteLine(IsValid("({[)})"));
            Console.WriteLine(IsValid("({()})"));
            Console.WriteLine(IsValid("()"));
        }
        static bool IsValid(string s)
        {
            Stack<char> myStack = new Stack<char>();
            foreach (char ch in s)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    myStack.Push(ch);
                } else
                {
                    if (myStack.Count == 0)
                    return false;
                
                    char reverse;
                    if (ch == ')')
                    {
                        reverse = '(';
                    }
                    else if (ch =='}')
                    {
                        reverse = '{';
                    } 
                    else
                    {
                        reverse = '[';
                    }
                    if (reverse != myStack.Pop())
                    {
                        return false;
                    }
                }
            }
            return myStack.Count == 0;
        }
    }
}
