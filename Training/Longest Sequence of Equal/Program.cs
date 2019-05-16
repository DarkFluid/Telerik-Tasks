using System;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());


            int[] data = new int[n];

            for (int i = 0; i < n; i++)
            {
                data[i] = int.Parse(Console.ReadLine());
            }

            int number = data[0], streak = 1, highestSteak = 0;

            for (int i = 1; i < n; i++)
            {
                if (number == data[i])
                {
                    streak++;
                    if (highestSteak < streak)
                    {
                        highestSteak = streak;
                    }
                }
                else
                {
                    number = data[i];
                    streak = 1;
                }
            }
            Console.WriteLine(highestSteak);
        }
    }
}
