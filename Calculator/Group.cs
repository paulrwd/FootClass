using System.Collections;
using System.Collections.Generic;

namespace Calculator
{
	public class Group
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int? Year { get; set; }

		public virtual ICollection<Song> Songs { get; set; }

	}
}
