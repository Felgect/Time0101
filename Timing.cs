using System;
using System.Diagnostics;

public class Class1
{
	public Class1()
	{
		namespace Timing
{
	internal class Timing
	{
		TimeSpan duration; 
		TimeSpan[] threads; 
		public Timing()
		{
			duration = new TimeSpan(0);
			threads = new TimeSpan[Process.GetCurrentProcess().
			Threads.Count];
		}
	}
}
