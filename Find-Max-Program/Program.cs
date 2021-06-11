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
           string maxNum = FindMaxNumber.FindMax("Apple", "Banana", "Peach");
            Console.WriteLine(maxNum);
        }
    }
}
