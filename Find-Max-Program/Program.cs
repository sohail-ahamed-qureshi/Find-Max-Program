﻿using System;

namespace Find_Max_Program
{
    class Program
    {
        /// <summary>
        /// Find Maximum program with test cases.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum of Numbers program");
           int maxNum = FindMaxNumber.FindMax(20, 10, 20);
            Console.WriteLine(maxNum);
        }
    }
}
