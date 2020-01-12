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
            for (int i = inputArray.Length - 1; i >= 0; i--)
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
        static bool CompareArrays(int[] inputArray1, int[] inputArray2)
        {
            if (inputArray1.Length == inputArray2.Length)
            {
                int[] tempArray1 = inputArray1;
                int[] tempArray2 = inputArray2;
                Array.Sort(tempArray1);
                Array.Sort(tempArray2);
                for (int i = 0; i < tempArray1.Length; i++)
                {

                    if (tempArray1[i] != tempArray2[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;

        }
    }
}
