using System;
using System.Collections.Generic;

namespace valid_parantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "{{((]))";
            Console.WriteLine(IsValid(s));
        }

       static bool IsValid(string s)
        {
            List<char> p = new List<char>();
            foreach (char ch in s)
            {
                if (ch == '(' || ch == '{' || ch == '[')
                {
                    p.Add(ch);
                }
                else
                {
                    if (p.Count == 0)
                    {
                        return false;
                    }

                    char reverse;
                    if (ch == ')')
                    {
                        reverse = '(';
                    }
                    else if (ch == '}')
                    {
                        reverse = '{';
                    }
                    else
                    {
                        reverse = '[';
                    }
                    int lastIndex = p.Count - 1;
                    if (reverse == p[lastIndex])
                    {
                        p.RemoveAt(lastIndex);
                    }
                    else
                    {
                        return false;
                    }
                }
            }

            return p.Count == 0;
        }


    }
}

