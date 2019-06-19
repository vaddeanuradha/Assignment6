using System;

namespace FindStrStrPos8
{
    class Program
    {
        public static int strstr(string s,string x)
        {
            int pos = 0,lenS=s.Length,lenX=x.Length;
            int count = 0;
            for (int i=0;i<lenS; i++)
            {
                for(int j=0;j<lenX;j++)
                {
                    if (s[i] != x[j])
                    {
                        if (count > 0)
                        { 
                        i = i - count;
                        count = 0;

                        }
                            break;
                    }
                    else
                    {
                            i++;
                        count++;
                    }
                }
                if (count==lenX)
                {
                    pos = i - lenX;
                    return pos;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            string str1 = "geeksforgeeks";
            string str2 = "for";
            int p= strstr(str1, str2);
            Console.WriteLine("The position is :  " + p);
            Console.Read();
        }
    }
}
