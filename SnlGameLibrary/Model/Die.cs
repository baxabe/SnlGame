using System;

namespace SnlGame.Model
{
    class Die
    {
        readonly Random rnd = new Random();

        public int Value { get; private set; }

        public int Throw()
        {
            Value = rnd.Next(1, 7);
            return Value;
        }
    }
}
