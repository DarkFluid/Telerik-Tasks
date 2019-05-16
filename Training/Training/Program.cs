using System;


namespace training
{
    class BiggestPrimeNumber
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int result = 0;

            for (int i = input; i > 0; i--)
            {
                bool isPrime = true;
                if ((i & 1) != 0)
                {
                    for (int j = 3; j <= Math.Sqrt(i); j += 2)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                    if (isPrime)
                    {
                        result = i;
                        break;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}