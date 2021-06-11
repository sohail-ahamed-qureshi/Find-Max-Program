using System;

namespace Find_Max_Program
{
    public class FindMaxNumber
    {
        /// <summary>
        /// UC2-Find Maximum of 3 Floats using Method Overloading polymorphism 
        /// </summary>
        /// <param name="firstNum"></param>
        /// <param name="secondNum"></param>
        /// <param name="thirdNum"></param>
        /// <returns></returns>
        public static int FindMax(int firstNum, int secondNum, int thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) >= 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) >= 0))
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) >= 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) >= 0))
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) >= 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) >= 0))
            {
                return thirdNum;
            }
            return default;
        }

        public static float FindMax(float firstNum, float secondNum, float thirdNum)
        {
            if (firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) >= 0 && (firstNum.CompareTo(thirdNum) > 0) ||
                firstNum.CompareTo(secondNum) > 0 && (firstNum.CompareTo(thirdNum) >= 0))
            {
                return firstNum;
            }
            if (secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) >= 0 && (secondNum.CompareTo(thirdNum) > 0) ||
                secondNum.CompareTo(firstNum) > 0 && (secondNum.CompareTo(thirdNum) >= 0))
            {
                return secondNum;
            }
            if (thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) >= 0 && (thirdNum.CompareTo(secondNum) > 0) ||
                thirdNum.CompareTo(firstNum) > 0 && (thirdNum.CompareTo(secondNum) >= 0))
            {
                return thirdNum;
            }
            return default;
        }


    }
}
