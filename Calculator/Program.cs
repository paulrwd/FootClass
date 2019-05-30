using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using FootClass;

namespace Calculator
{




	class Program
	{


		static void Main(string[] args)

		{
			Console.WriteLine("Введите число: ");
			var input = Console.ReadLine();
			if (int.TryParse(input, out int result))
			{
				//var isEven = IsEven(result);
				var isEven = result.IsEven();
				if (isEven)
				{
					Console.WriteLine($"{result} - Четное");
				}
				else
				{
					Console.WriteLine($"{result} - Нечетное");
				}
			}

			int h = 182;
			h.isDividedBy(7);
			Console.WriteLine(Convert.ToInt32(input).isDividedBy(7));

			var roads = new List<Road>();
			for (var i = 0; i < 10; i++)
			{
				var road = new Road();
				road.CreateRandomRoad(1000, 10000);
				roads.Add(road);
			}


			var roadsName = roads.ConvertToString();
			Console.WriteLine(roadsName);

			Console.ReadLine();

		}

		


		public static int Factorial(int value)
		{
			if (value <= 1)
			{
				return 1;
			}
			else
			{
				return value * Factorial(value - 1);
			}

		}
	}
}
