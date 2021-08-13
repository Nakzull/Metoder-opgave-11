using System;
using System.Collections.Generic;

namespace Metoder_opgave_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5;
            int number2 = 8;
            int addNumbers = AddNumbers(number1, number2);
            double divideNumbers = DivideNumbers(number1, number2);
            int timesDivided = TimesDivided(number1, number2);
            List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int biggestNumber = BiggestNumber(numbers);
            double averageNumber = AverageNumber(numbers);
            string sortStatus = ListSortChecker(numbers);
        }

        public static int AddNumbers(int number1, int number2)
        {
            int resultAdd = number1 + number2;
            return resultAdd;
        }
        public static double DivideNumbers(double number1, double number2)
        {
            double resultDivide = number1 / number2;
            return resultDivide;
        }
        public static int TimesDivided(int number1, int number2)
        {
            int resultTimesDivided = (int)Convert.ToSingle(number1 / number2);
            return resultTimesDivided;
        }
        public static int BiggestNumber(List<int> numbers)
        {
            int biggestNumber = numbers[0];
            for (int i = 1; i < numbers.Count; ++i)
            {
                if (numbers[i] > biggestNumber)
                {
                    biggestNumber = numbers[i];
                }
            }
            return biggestNumber;
        }
        public static double AverageNumber(List<int> numbers)
        {
            double numbersAdded = 0;
            for (int i = 0; i < numbers.Count; i++)
                numbersAdded = numbersAdded + numbers[i];
            double averageNumber = numbersAdded / numbers.Count;
            return Math.Round(averageNumber);
        }
        public static string ListSortChecker(List<int> numbers)
        {
            string sortStatus = "List is sorted";
            for (int i = 1; i < numbers.Count - 1; i++)
            {
                if (numbers[i] < numbers[i - 1] || numbers[i] > numbers[i + 1])
                {
                    sortStatus = "List is not sorted";
                    break;
                }
            }
            return sortStatus;
        }
    }
}