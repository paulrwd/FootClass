using System;


namespace FootClass
{
    class BMW7 : ICar
    {
        public int Move(int distance)
        {
            return distance / 100;
        }
    }
}
