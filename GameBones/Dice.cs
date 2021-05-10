using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameBones
{
    class Dice
    {
        int FirstDice;
        int SecondDice;
        static Random rnd = new Random();
        public Dice()
        {
            FirstDice = rnd.Next(1, 7);
            SecondDice = rnd.Next(1, 7);
        }
        public int GetFirst
        {
            get
            {
                return FirstDice;
            }
        }
        public int GetSecond
        {
            get
            {
                return SecondDice;
            }
        }

    }
}
