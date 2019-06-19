using System;

namespace LCSLenght5
{
    class Program
    {
      
        public static void PrintLCSLengthAndString(string str1, string str2)
        {
            int m = str1.Length;
            int n = str2.Length;
            int[,] L = new int[m + 1, n + 1];
            int result = 0;
            for (int i = 0; i <= m; i++)
            {
                for (int j = 0; j <= n; j++)
                {
                    if (i == 0 || j == 0)
                        L[i, j] = 0;
                    else if (str1[i - 1] == str2[j - 1])
                    {
                        L[i, j] = L[i - 1, j - 1] + 1;
                        result = Math.Max(result, L[i, j]);
                    }
                    else
                        L[i, j] = 0;
                }
            }
            Console.WriteLine("The Longest Substring Length is :" + result);

        }
       
        static void Main(string[] args)
        {
            string X = "zxabcdezy";
            string Y = "yzabcdezx";
            PrintLCSLengthAndString(X, Y);
            Console.Read();

        }
    }
}
