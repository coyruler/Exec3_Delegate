using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> items = new List<int> { 577, 54, 588, 12, 3, 8, 90, 11 };
			Func<int, bool> isEven = n => n % 2 == 0;
			List<int> EvenItems = GetEvenItems(items, isEven);
			foreach (var item in EvenItems)
			{
				Console.WriteLine(item);
			}
		}
		static List<int> GetEvenItems(List<int> source, Func<int, bool> func)
		{
			var result = new List<int>();

			foreach (int item in source)
			{
				if (func(item) == true)
				{
					result.Add(item);
				}
			}

			return result;
		}
	}

}
