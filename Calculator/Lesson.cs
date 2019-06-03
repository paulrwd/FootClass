using System;
using System.Dynamic;

namespace Calculator
{
	class Lesson
	{

		public string Name { get; }
		public DateTime Begin {get; private set; }

		public event EventHandler<Lesson> Started; 

		public Lesson(string name)
		{
			Name = name;
		}

		public void Start()
		{
			Begin = DateTime.Now;
			Started?.Invoke(this,this);
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
