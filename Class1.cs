using System;
using System.Diagnostics;

public class Class1
{
	private static void Main()
	{
		static void Main()
		{
			int n = 10000;
			int[] a = new int[n];
			Random rnd = new Random();
			for (int i = 0; i < n; i++)
				a[i] = rnd.Next() % 500;
			TimingAlg objT = new TimingAlg();
			Stopwatch stpWatch = new Stopwatch();
			objT.StartTime();
			stpWatch.Start();
			SortInsertion(a);
			stpWatch.Stop();
			objT.StopTime();
			Console.WriteLine("StopWatch: " +
			stpWatch.Elapsed.ToString());
			Console.WriteLine("Timing: " +
			objT.Result().ToString());
		}
	}
}
