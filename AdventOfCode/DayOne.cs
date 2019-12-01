using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdventOfCode
{
	class DayOne
	{
		public int CalculateSumOfFuel()
		{
			var lines = File.ReadLines("Input/DayOne.txt");
			//var lines = new int[] { 100756 };
			var sumOfFuel = 0;
			foreach (var line in lines)
			{
				int moduleMass = Convert.ToInt32(line);
				int moduleFuel = CalculateFuel(moduleMass);
				var currentFuel = CalculateFuel(moduleFuel);
				while (currentFuel > 0)
				{
					moduleFuel += currentFuel;
					currentFuel = CalculateFuel(currentFuel);
				}
				sumOfFuel += moduleFuel;
			}
			return sumOfFuel;
		}
		public int CalculateFuel(int mass)
		{
			return Convert.ToInt32(Math.Floor(mass / 3.0)) - 2;
		}
	}
}
