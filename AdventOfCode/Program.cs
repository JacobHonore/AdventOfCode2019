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
			//var lines = new int[] { 100756 };
			var sum = 0;
			foreach (var line in lines)
			{
				int input = Convert.ToInt32(line);
				int moduleFuel = Program.CalculateFuel(input);
				var currentFuel = Program.CalculateFuel(moduleFuel);
				while (currentFuel > 0) {
					moduleFuel += currentFuel;
					currentFuel = Program.CalculateFuel(currentFuel);
				}
				sum += moduleFuel;
			}
			return sum;
		}
		public static int CalculateFuel(int input) {
			return Convert.ToInt32(Math.Floor(input / 3.0)) - 2;
		}
	}
}
