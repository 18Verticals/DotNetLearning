﻿using System.Collections.Generic;

namespace Loop_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While Loop
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine(i); //Output: 0 1 2 3 4
                i++;
            } 

            //Do While
            //Whether condition true or false, this statement will run at least first time
            int j = 100;
            do
            {
                Console.WriteLine(j); //Output: 100
                j++;
            }
            while (j < 10);

            //For Loop
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine(k); //Output: 0 1 2 3 4
            }

            //ForEach Loop
            int[] arr = new int[] { 1, 2, 3, 4 };
            foreach (int items in arr)
            {
                Console.WriteLine(items); //Output: 1 2 3 4
            }

            Console.ReadLine();
        }
    }
}
