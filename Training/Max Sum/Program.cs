namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            int sum = 0, biggestSum = 0;

            int data;

            for (int i = 0; i < n; i++)
            {
                data = int.Parse(System.Console.ReadLine());
                if (sum + data > 0)
                {
                    sum += data;
                    if (sum > biggestSum) biggestSum = sum;
                }
                else
                {
                    sum = 0;
                }
            }

            System.Console.WriteLine(biggestSum);
        }
    }
}
