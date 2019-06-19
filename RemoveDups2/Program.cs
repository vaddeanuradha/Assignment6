using System;
using System.Collections;

namespace RemoveDups2
{
    class Program
    {
        public static Stack st = new Stack();
        public static void RemoveDups(string str)
        {
            int len = str.Length;
            for(int i =0;i<len;i++)
            {
                if (st.Count == 0)
                    st.Push(str[i]);
                else if ((char)st.Peek() == str[i])
                    st.Pop();
                else if(str[i-1]!=str[i])
                    st.Push(str[i]);
            }
            if (st.Count == 0)
                Console.WriteLine("The Output String is Empty ");
            else
            Print();
        }
        public static void Print()
        {
            if (st.Count > 0)
            {
                // Hold all items in Function  
                // Call Stack until we  
                // reach end of the stack  
                char x = (char)st.Peek();
                st.Pop();
                Print();
                Console.Write(x);
                
            }
           
        }
        static void Main(string[] args)
        {
            string str1 = "azxxzy";
            Console.WriteLine("The input string is :     " + str1);
            Console.Write("The output string is :    ");
            RemoveDups(str1);
            Console.WriteLine();
            string str2 = "caaabbbaacdddd";
            Console.WriteLine("The input string is :     " + str2);
            Console.Write("The output string is :    ");
            RemoveDups(str2);
            Console.WriteLine();
            string str3 = "acaaabbbacdddd";
            Console.WriteLine("The input string is :     " + str3);
            Console.Write("The output string is :    ");
            RemoveDups(str3);


            Console.Read();
        }
    }
}
