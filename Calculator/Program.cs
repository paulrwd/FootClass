using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using FootClass;

namespace Calculator
{
	

	

	class Program
	{


		static void Main(string[] args)
		{
			using (var sw= new StreamWriter("test.txt",true, Encoding.ASCII))
			{
				sw.WriteLine("Привет");
				sw.WriteLine("Hello user");
			}

			using (var sr = new StreamReader("test.txt"))
			{
				var text1 = sr.ReadLine();
				var text = sr.ReadToEnd();
				Console.WriteLine(text);
				Console.ReadLine();
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
