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

		static void Main(string[] args)
		{
			var photo = new Photo("hello.png")
			{
				Path = @"C:\hello.png"
			};

			var type = typeof(Photo);
			var attributes = type.GetCustomAttributes(false);
			foreach (var attribute in attributes)
			{
				Console.WriteLine(attribute);
			}

			var properties = type.GetProperties();
			foreach (var prop in properties)
			{
				var attrs = prop.GetCustomAttributes(false);

				if (attrs.Any(a => a.GetType() == typeof(GeoAttribute)))
				{
					Console.WriteLine(prop.PropertyType + " " + prop.Name + " " + prop.Attributes);
				}

				
				
				

			}

			Console.ReadLine();
		}
	}
}
