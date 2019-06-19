using System;

namespace ConvertStringToInt7
{
    class Program
    {
        public static int atoi(string st)
        {
            int res = 0;
            int len = st.Length;
            for (int i=0;i<len;i++)
            {
                int t = st[i]-'0';
                res = res * 10 + t;
            }
            return res;
        }
        static void Main(string[] args)
        {
            string str = "3426";
            Console.WriteLine("The atoi Value is :   " + atoi(str));
            Console.Read();
        }
    }
}
