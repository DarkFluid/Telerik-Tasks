using System;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int numberOfElements = int.Parse(Console.ReadLine());
            int result = 0;

            int[] input = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                input[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(input);

            for (int i = arraySize - 1; i > arraySize - 1 - numberOfElements; i--)
            {
                result += input[i];
            }

            Console.WriteLine(result);
        }
    }
}