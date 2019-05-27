using System;


namespace FootClass
{
    public class Eating<T, TT>
    where T: Product
    where TT:IEquatable<T>
    {
        public int Volume { get; private set; }

        public void Add(T product)
        {
            Volume += product.Volume * product.Energy;
        }
    }
}
