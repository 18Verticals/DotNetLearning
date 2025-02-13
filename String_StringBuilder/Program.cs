using System;
using System.Diagnostics;
using System.Text;

namespace String_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // String is IMMUTABLE. That mean you couldn’t modify it after it is created.
            String str1 = "Interview"; //Both str1 strings are different and occupy different memory in process
            str1 = str1 + "Happy";
            Console.WriteLine(str1);

            //StringBuilder is MUTABLE  
            StringBuilder str2 = new StringBuilder();
            str2.Append("Interview"); // str2 Only one string in memory
            str2.Append("Happy");
            Console.WriteLine(str2);

            Console.ReadLine();
        }
    }
}
