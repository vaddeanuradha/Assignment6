using System;

namespace StringRotated
{
    class Program
    {
        public static bool IsRotated(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }
                      
            int len = str2.Length;
            //checking the string is either anti clock wise or clock wise

            if (str1 == str2.Substring(len - 2,2) + str2.Substring(0, len - 2)
                || str1 == str2.Substring(2, len - 2) + str2.Substring(0, 2))
                return true;
            else
                return false;

          
        }

        static void Main(string[] args)
        {
            string str1 = "amazon";
            string str2 = "onamaz";
            string str3 = "azonam";
            string str4 = "zonama";
            //here i am taking two examples to check anticlock wise and clock wise rotation by two places
            //The first two are true so  it prints Yes
            //The third one is also ratated but it rotated by three places so it prints No

            Console.WriteLine(IsRotated(str1, str2) ? "Yes" : "No");
            Console.WriteLine(IsRotated(str1, str3) ? "Yes" : "No");
            Console.WriteLine(IsRotated(str1, str4) ? "Yes" : "No");
            Console.Read();
        }
    }
}
