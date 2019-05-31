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
			var cars = new List<Car>()
			{
				new Car() {Name = "Ford", Number = "А001АА01"},
				new Car() {Name = "Lada", Number = "В782ВТ77"}
			};

			var parking = new Parking();
			foreach (var car in cars)
			{
				parking.Add(car);
			}

			Console.WriteLine(parking["В782ВТ77"]?.Name);
			Console.WriteLine(parking["В782ВТ37"]?.Name);

			Console.WriteLine("Введите номер нового автомобиля");
			var num = Console.ReadLine();

			parking[1] = new Car() { Name = "BMW", Number = num };
			parking.Add(parking[1]);
			Console.WriteLine(parking[1]);

			foreach (var car in parking)
			{
				Console.WriteLine(car);
			}

			foreach (var name in parking.GetNames())
			{
				Console.WriteLine(name);
			}

			Console.ReadLine();
		}

	}
}
