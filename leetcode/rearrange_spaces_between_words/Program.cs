using System;
using System.Text;

namespace rearrange_spaces_between_words
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = " This   is a   sentence  ";
            Console.WriteLine(ReorderSpaces(text));
        }
        static string ReorderSpaces(string text)
        {
            StringBuilder str = new StringBuilder();
            int spaces = 0;
            int words = 0;
            foreach (char ch in text)
            {
                if (ch == ' ')
                {
                    spaces++;
                }
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ' && (i - 1 < 0 || text[i - 1] == ' '))
                {
                    words++;
                }
            }
            int spaceBetweenWords = 0;
            int spaceAtTheEnd = spaces;

            if (words > 1)
            {
                spaceBetweenWords = spaces / (words - 1);
                spaceAtTheEnd = spaces % (words - 1);
            }
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] != ' ')
                {
                    str.Append(text[i]);
                    if (i - 1 < 0 || text[i - 1] == ' ')
                    {
                        words--;
                    }
                }

                if (text[i] != ' ' && (i + 1 >= text.Length || text[i + 1] == ' '))
                {
                    if (words != 0)
                    {
                        str.Append(' ', spaceBetweenWords);
                    }
                }
                if (spaceAtTheEnd == 0)
                {
                    str.ToString().TrimEnd();
                }
             }
              if (spaceAtTheEnd > 0)
                {
                    str.Append(' ', spaceAtTheEnd);
                }
            return str.ToString();
        }
    }
}
