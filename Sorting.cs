using System;

public class Class1
{
	public void BubleSort(int[] a)
	{
		int N = a.Length;
		for (int i = 1; i < N; i++)
			for (int j = N - 1; j => i; j--)
				if (a[j - 1] > a[j])
				{
					int t = a[j - 1];
					a[j - 1] = a[j];
					a[j] = t;
	}
}
