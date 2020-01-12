using System;

namespace HomeWork2
{
    class Program
    {
        static void Main()
        {
            foreach (var item in NumberToArray(1234567))
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
        }
        static int[] NumberToArray(int inputNumber)
        {
            int[] inputArray = new int[Convert.ToString(inputNumber).Length];
            for (int i = inputArray.Length - 1; i >=0; i--)
            {
                inputArray[i] = inputNumber % 10;
                inputNumber = inputNumber / 10;
            }
            return inputArray;
        }
        static bool IsNoDuplicates(int[] inputArray)
        {
            int[] tempArray = inputArray;
            Array.Sort(tempArray);
            for (int i = 0; i < tempArray.Length - 1; i++)
            {
                if (tempArray[i] == tempArray[i + 1])
                {
                    return false;
                }
            }
            return true;
        }
    }
}
