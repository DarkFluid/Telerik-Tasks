using System;
using System.Numerics;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            BigInteger result = new BigInteger();
            result = BigInteger.Add(1, result);

            for (int i = 1; i <= input; i++)
            {
                result = BigInteger.Multiply(i, result);
            }

            Console.WriteLine(result);
        }
    }
}
