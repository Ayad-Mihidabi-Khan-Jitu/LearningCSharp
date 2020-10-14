using System;
namespace Practice
    {
    class abcSubstring
        {
        static void Main()
            {
            string superstring = "abcabcabca"; //ababc = 
            string substring = "abc";
            int cou = 0,rcou=0;

            for(int i = 0; i < superstring.Length- substring.Length; i++)
                {
                for (int j = 0; j < substring.Length; j++)
                    {
                    if (superstring[j+i] == substring[j]) cou++;
                    else cou = 0;
                    }
                rcou = rcou + cou;
                }
            Console.WriteLine(rcou/substring.Length);
            }
        }
    }
