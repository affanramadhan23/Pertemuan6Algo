﻿using System;

namespace SearchAlgorithm
{
    class program
    {
        //Array to be seacrhed
        int[] arr = new int[20];
        //Number of elements in the array
        int n;
        //get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.Write("Enter the number of elements in the array: ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Array should have minimum 1 and maximum 2o elements.\n");
            }
            //Accept array elements
            Console.WriteLine("");
            Console.WriteLine("---------------------");
            Console.WriteLine("Enter array elements ");
            Console.WriteLine("---------------------");
            for (i = 0; i < n; i++)
            {
                Console.Write("<" + (i + 1) + ">");
                String s1 = Console.ReadLine();
                arr[i] = Int32.Parse(s1);
            }
        }
    }
}