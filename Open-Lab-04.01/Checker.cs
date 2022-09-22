using System;

namespace Open_Lab_04._01
{
    public class Checker
    {
        public bool DoubleLetters(string str)
        {
            bool has2letters = false;
            for (int i = 0; i < str.Length-1; i++)
            {
                has2letters = str[i] == str[i + 1];
                if (has2letters == true)
                {
                    break;
                }
            }
            return has2letters;
        }
    }
}
