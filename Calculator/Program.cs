using System;
using System.Collections.Generic;
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
            //Club club1 = new Club
            //{
            //    ClubName = "Spartak",
            //    ClubCity = "Moscow",
            //    Points = 36
            //};

            //Club club2 = new Club
            //{
            //    ClubName = "Krilya",
            //    ClubCity = "Samara",
            //    Points = 32
            //};

            //Game game = new Game("10.05.2019",club1.ClubName, club2.ClubName);
            //Console.WriteLine(Factorial(5));
            //Console.ReadLine();

            var 

            var list = new List<int>();


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
