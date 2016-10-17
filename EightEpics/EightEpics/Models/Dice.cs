using System;

namespace EightEpics.Models
{
    public class Dice
    {
        private static Random rdm = new Random();

        public int Result { get; set; }

        public Dice()
        {
            Roll();
        }

        public int Roll()
        {
            Result = rdm.Next(1, 7);

            return Result;
        }
    }
}
