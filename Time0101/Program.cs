using System;
using System.Diagnostics;
namespace Time0101
{
    class Program
    {

        static void Main(string[] args)

        {
            const int n = 10000;
            int[] a = new int[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
                a[i] = rnd.Next() % 500;
            Stopwatch stpWatch = new Stopwatch();
            stpWatch.Start();
            stpWatch.Stop();
            Console.WriteLine($"StopWatch:{stpWatch.ElapsedMilliseconds.ToString()}");
        }
    }
}

