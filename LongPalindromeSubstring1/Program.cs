using System;

namespace LongPalindromeSubstring1
{
    class Program
    {
        public static bool isPalindrome(string str)
        {
            for (int i = 0, j = str.Length - 1; i < j; i++, j--)
            {
                if (str[i] != str[j])
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string str = " yesmomsemoomes";
            string maxPalendrome = "";
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = i + 1; j < str.Length; j++)
                {
                    if (str[i] == str[j])
                    {
                        string substr = str.Substring(i, j - i+1);
                        if (isPalindrome(substr))
                            if (maxPalendrome.Length < substr.Length)
                                maxPalendrome = substr;
                    }
                }
            }
            Console.WriteLine("The max palindrome of the substring is :" + maxPalendrome);
            Console.Read();
        }
    }
}
