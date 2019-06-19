using System;
using System.Collections.Generic;

namespace LongestUniqSubString6
{
    class Program
    {
        public static int LUSubString(string s)
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            int mLen = 0, cLen = 0, index = 0, i = 0;
            while(i<s.Length)
            {
                char c = s[i];
                if(!d.ContainsKey(c))
                {
                    cLen++;
                    d.Add(c, i);
                }
                else
                {
                    index = Math.Max(index, d[c]+1);
                    cLen = i - index+1;

                }
                if (cLen > mLen)
                {
                    mLen = cLen;
                }
                i++;
            }
            return mLen;            

        }
        static void Main(string[] args)
        {
            string str = "abca";
            Console.WriteLine("The Max Lenght of Unique Char Substring:   " + LUSubString(str));
            Console.Read();
        }
    }
}
