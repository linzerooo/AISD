using System.Diagnostics;

public partial class Program
{
    public static void Main(string[] args)
    {
        List<long> time = new List<long>();
        List<int> iteration = new List<int>();

        List<List<int>> arr = new List<List<int>>();
        var n = 100;
        for (var i = 0; i < 50; i++)
        {
            List<int> list = new List<int>();
            for (var j = 0; j < n; j++)
            {
                var r = new Random();
                list.Add(r.Next(1000));
            }
            n += 200;
            arr.Add(list);
        }

        foreach (var a in arr)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            
            PatienceSorting(a);
            iteration.Add(countIt);
            stopwatch.Stop();
            time.Add(stopwatch.ElapsedMilliseconds);
            countIt = 0;
        }

    }
}
