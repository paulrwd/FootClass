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
			using (var context = new MyDBContext())
			{
				var group = new Group()
				{
					Name = "Rammstein", Year = 1994
				};
				var group2 = new Group()
				{
					Name = "Linkin Park"
				};

				
				context.Groups.Add(group);
				context.Groups.Add(group2);

				context.SaveChanges();

				var songs = new List<Song>
				{
					new Song() {Name = "In the End", GroupId = group2.Id},
					new Song() {Name = "Numb", GroupId = group2.Id},
					new Song() {Name = "Mutter", GroupId = group.Id}
				};

				context.Songs.AddRange(songs);
				context.SaveChanges();

				var s = context.Groups.Single(x => x.Id == group.Id);
				s.Name = "Rammshtein";
				context.SaveChanges();

				foreach (var song in songs)
				{
					Console.WriteLine($"Song name: {song.Name}, Group name: {song.Group.Name}");
				}
				Console.WriteLine($"id: {group.Id}, name: {group.Name}, year: {group.Year}");
				Console.WriteLine($"id: {group2.Id}, name: {group2.Name}, year: {group2.Year}");
			}
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
