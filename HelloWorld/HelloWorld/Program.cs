using System;

namespace HelloWorld
{//inheritance namespace
    class Program
    {
        static void Main(string[] args)
        {
            char[] chars = { 'a', 'b', 'c' };
            String s = new String(chars);
            String s1 = "abcd";
            int len1 = s1.Length;
            int len2 = s.Length;
            Console.WriteLine(len1 + " " + len2);
            Console.ReadLine();
        }
    }
}
