using System;

namespace remove_outermost_parantheses
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = "(()())(())";
            Console.WriteLine(RemoveOuterParentheses(S));
        }

        static string RemoveOuterParentheses(string S)
        {
            string result = "";
            string starter = "";
            int count = 0;
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == '(')
                {
                    count++;
                    if (count > 1)
                    {
                        starter += S[i];
                    }
                }
                else
                {
                    count--;
                    if (count > 0)
                    {
                        starter += S[i];
                    }
                    else
                    {
                        result += starter;
                        starter = "";
                    }
                }
            }

            return result;
        }
    }
}
