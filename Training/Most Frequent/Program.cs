namespace training
{
    using System.Linq;
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(System.Console.ReadLine());
            int[] data = new int[n];

            for (int i = 0; i < n; i++)
            {
                data[i] = int.Parse(System.Console.ReadLine());
            }

            var max = (data.GroupBy(x => x).Select(x => new { num = x, count = x.Count() }).OrderByDescending(g => g.count).Select(g => g.num).First());

            System.Console.WriteLine($"{max.Key} ({max.Count()} times)");
        }
    }
}