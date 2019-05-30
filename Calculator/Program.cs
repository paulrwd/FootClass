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
			var rnd = new Random();
			var products = new List<Product>();
			for (var i = 0; i < 10; i++)
			{
				var product = new Product()
				{
					Name = "Продукт" + i,
					Energy = rnd.Next(8, 14)
				};
				products.Add(product);
			}

			var result = from item in products
						 where item.Energy < 200
						 orderby item.Energy
						 select item;

			var result2 = products.Where(item => item.Energy < 100 || item.Energy > 450);

			foreach (var item in result)
			{
				Console.WriteLine(item);
			}

			foreach (var item in result2)
			{
				Console.WriteLine(item);
			}

			var selectCollection = products.Select(product => product.Energy);
			foreach (var item in selectCollection)
			{
				Console.WriteLine(item);
			}

			var orderbyCollection = products.OrderBy(product => product.Energy).ThenByDescending(product => product.Name);
			foreach (var item in orderbyCollection)
			{
				Console.WriteLine(item);
			}

			var groupbyCollection = products.GroupBy(product => product.Energy);
			foreach (var group in groupbyCollection)
			{
				Console.WriteLine($"Key: {group.Key}");
				foreach (var item in group)
				{
					Console.WriteLine(item);
				}
			}

			products.Reverse();

			foreach (var item in products)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine(products.All(item => item.Energy == 10));
			Console.WriteLine(products.Any(item => item.Energy == 10));
			Console.WriteLine(products.Contains(products[5]));

			var array1 = new int[]{1, 2, 3, 4};
			var array2
				= new int[] { 3, 4, 5, 6 };
			foreach (var item in array1)
			{
				Console.WriteLine(item);
			}
			Console.WriteLine("_________");
			var union = array1.Union(array2);
			foreach (var item in union)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("_________");
			var intersect = array1.Intersect(array2);
			foreach (var item in intersect)
			{
				Console.WriteLine(item);
			}

			Console.WriteLine("_________");
			Console.WriteLine(array1.Sum());
			Console.WriteLine("_________");
			Console.WriteLine(products.Min(p => p.Energy));
			Console.WriteLine("_________");
			Console.WriteLine(products.Max(p => p.Energy));
			Console.WriteLine("_________");
			Console.WriteLine(array1.FirstOrDefault());
			Console.WriteLine("_________");
			Console.WriteLine(array2.LastOrDefault());


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
