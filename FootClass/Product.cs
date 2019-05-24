using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootClass
{
    public abstract class Product
    {
        public string Name { get; set; }

        public int Calorie { get; set; } 

        public int Volume { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
