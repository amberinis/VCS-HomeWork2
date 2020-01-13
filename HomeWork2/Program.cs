using System;

namespace HomeWork2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine(CalcMagicNumber(GetIntNumberInput()));
        }
        static int CalcMagicNumber(int multiplNumber)
        {
            int[] magicNumberArr;
            int[] tempNumberArr;
            int magicNumber = 102344;
            int tempNumber;
            do
            {
                do
                {
                    magicNumber += 1;
                    magicNumberArr = NumberToArray(magicNumber);
                } while (!IsNoDuplicates(magicNumberArr));
                tempNumber = magicNumber * multiplNumber;
                tempNumberArr = NumberToArray(tempNumber);
            } while (!CompareArrays(magicNumberArr, tempNumberArr));
            return magicNumber;
        }
        static int[] NumberToArray(int inputNumber)
        {
            int[] inputArray = new int[Convert.ToString(inputNumber).Length];
            for (int i = inputArray.Length - 1; i >= 0; i--)
            {
                inputArray[i] = inputNumber % 10;
                inputNumber /= 10;
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
        static int GetIntNumberInput()
        {
            int inputNumber;
            string inputString;
            do
            {
                Console.Write($"Please enter number between 1 and 10: ");
                inputString = Console.ReadLine();
                while (!IsNumber(inputString))
                {
                    Console.Write("Please enter correct number!: ");
                    inputString = Console.ReadLine();
                }
                inputNumber = Convert.ToInt32(inputString);
            } while (inputNumber <= 1 || inputNumber >= 10);
            return inputNumber;
        }
        static bool IsNumber(string testNumber)
        {
            if (string.IsNullOrEmpty(testNumber))
            {
                return false;
            }

            for (int i = 0; i < testNumber.Length; i++)
            {
                char testSymbol = testNumber[i];
                if (!char.IsDigit(testSymbol))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
