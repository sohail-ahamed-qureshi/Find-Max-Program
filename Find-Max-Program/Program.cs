using System;

namespace Find_Max_Program
{
    class Program
    {
        /// <summary>
        /// UC2-Find Maximum of three floats program with test cases.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Find Maximum of Numbers program");
           float maxNum = FindMaxNumber.FindMax(0.2f, 0.1f, 0.0f);
            Console.WriteLine(maxNum);
        }
    }
}
