using System;
using System.CodeDom;
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
using System.Runtime.Remoting.Channels;
using FootClass;

namespace Calculator
{




	class Program
	{
		public delegate int MyHandler(int i);

		static void Main(string[] args)
		{
			var lesson = new Lesson("Программирование");

			lesson.Started += (sender, date) =>
			{
				Console.WriteLine(sender);
				Console.WriteLine(date);
			};

			lesson.Start();

			var list = new List<int>();
			for (int i = 0; i < 100; i++)
			{
				list.Add(i);
			}

			Console.WriteLine(list.Aggregate((x, y) => x + y));

			var result1 = Arg(list, delegate(int i)
			{

				var r = i * i;
				Console.WriteLine(r);
				return r;
			});

			var result2 = Arg(list, Method);

			var result3 = Arg(list, x => x * x * x);





			if(int.TryParse(Console.ReadLine(), out int result))
			{

				MyHandler handler = delegate (int i)
				{

					var r =  i * i;
					Console.WriteLine(r);
					return r;
				};

				//handler += Method;

				handler(result);

				MyHandler lambdaHandler = (i) => //i * i;
				{
					var r = i * i;
					Console.WriteLine(r);
					return r;
				};

				lambdaHandler(99);
			}

			

			Console.ReadLine();
		}

		public static int Arg(List<int> list, MyHandler handler)
		{
			int result = 0;

			foreach (var item in list)
			{
				result += handler(item);
			}

			return result;
		}


		public static int Method(int i)
		{
			var r = i * i * i;
			Console.WriteLine(r);
			return r;
		}

	}
}
