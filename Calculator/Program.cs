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
        public delegate void MyDelegate();
        public Action ActionDelegate;

        public delegate bool Predicate(int value);

        public delegate int Funk();

        public event MyDelegate Event;
        public event Action EventAction;

        public static void Method1()
        {
            Console.WriteLine("Method1");
        }
        public static int Method2()
        {
            Console.WriteLine("Method2");
            return 0;
        }
        public static void Method3(int i)
        {
            Console.WriteLine("Method3");
        }
        public static void Method4()
        {
            Console.WriteLine("Method4");
        }

        public delegate int ValueDelegate(int i);

        public static int MethodValue(int i)
        {
            Console.WriteLine(i);
            return i;
        }

        static void Main(string[] args)
        {
            #region delegate




            //MyDelegate myDelegate = Method1;
            //myDelegate += Method4;

            //MyDelegate myDelegate2 = new MyDelegate(Method4);

            //myDelegate();
            //myDelegate2 += Method4;
            //myDelegate2.Invoke();

            //MyDelegate myDelegate3 = myDelegate + myDelegate2;
            //myDelegate3.Invoke();

            //var valueDelegate = new ValueDelegate(MethodValue);
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate += MethodValue;
            //valueDelegate((new Random()).Next(10, 50));

            //Action action = Method1;
            //action();

            //Predicate<int> predicate;

            //Func<int, int> func = MethodValue;
            //if(func!=null)
            //{
            //    func(7);
            //}



            //Console.ReadLine();

            #endregion

            Person person = new Person();
            person.Name = "Вася";
            person.GoToSleep += Person_GoToSleep;
            person.DoWork += Person_DoWork;
            person.TakeTime((DateTime.Parse("27.05.2019 5:05:55")));
            person.TakeTime((DateTime.Parse("27.05.2019 21:05:55")));
        }

        private static void Person_DoWork(object sender, EventArgs e)
        {
            Console.WriteLine($"{((Person)sender).Name} работает работу");
        }

        private static void Person_GoToSleep()
        {
            Console.WriteLine("Пошел спать");
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
