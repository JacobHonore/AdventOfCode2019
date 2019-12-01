using System;
using System.IO;

namespace AdventOfCode
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			Console.WriteLine(Program.DayOne());
		}
		public static int DayOne()
		{
			var lines = File.ReadLines("DayOneInput.txt");
			var sum = 0;
			foreach (var line in lines)
			{
				int input = Convert.ToInt32(line);
				int divided = Convert.ToInt32(Math.Floor(input / 3.0));
				int subtracted = divided - 2;
				sum += subtracted;
			}
			return sum;
		}
	}
}
