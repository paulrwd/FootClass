using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootClass
{
    class LadaSeven : ICar
    {
        public int Move(int distance)
        {
            return distance / 40;
        }
    }
}
