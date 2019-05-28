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
using FootClass;

namespace Calculator
{
	

	

	class Program
	{


		static void Main(string[] args)
		{
			#region thread




			//Thread thread1 = new Thread(new ThreadStart(DoWork1));
			//thread1.Start();

			//Thread  thread2 = new Thread(new ParameterizedThreadStart(DoWork2));
			//thread2.Start(int.MaxValue);

			//int j = 0;
			//for (int i = 0; i < int.MaxValue; i++)
			//{
			//	j++;

			//	if (j % 10000 == 0)
			//	{
			//		Console.WriteLine("DoWork 3");
			//	}
			//}

			#endregion

			#region Async/await

			


			Console.WriteLine("Begin main");
			DoWork1Async(10);
			Console.WriteLine("Cont main");
			for (int i = 0; i < 10; i++)
			{
				Console.WriteLine("Main");
				
			}
			#endregion

			var result = SaveFileAsync("test.txt");
			Console.WriteLine("конец");
			Console.ReadLine();
		}

		static async Task<bool> SaveFileAsync(string path)
		{
			var result = await Task.Run(() => SaveFile(path));
			return result;
		}

		static bool SaveFile(string path)
		{
			var rnd = new Random();
			string text = "";
			for (int i = 0; i < 50000; i++)
			{
				text += rnd.Next().ToString();
			}

			using (var sw = new StreamWriter(path, false, Encoding.UTF8))
			{
				sw.WriteLine();
			}

			return true;
		}

		static async Task DoWork1Async(int max)
		{
			await Task.Run(() => DoWork1(max));
			Console.WriteLine("Do Work Async");
		}

		static void DoWork1(int max)
		{

			for (int i = 0; i < max; i++)
			{
				Console.WriteLine("DoWork");
			}
		}

		static void DoWork2(object max)
		{
			int j = 0;
			for (int i = 0; i < 10; i++)
			{
				j++;

				if (j % 1000 == 0)
				{
					Console.WriteLine("DoWork 2");
				}
			}
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
