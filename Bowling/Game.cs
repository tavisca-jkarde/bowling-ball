using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        int [] arrayBowling = new int[25];
        int arraycount = 0;
        int score = 0;

        public void Roll(int pins)
        {
            arrayBowling[arraycount] = pins;

            if (arrayBowling[arraycount] == 10) 
            {
                arrayBowling[arraycount + 1] = 0;
                arraycount++;


            } arraycount++;



        }

        public int GetScore()
        {
            for (int i = 0; i < 20; i++) 
            {
                score += arrayBowling[i];

                if (arrayBowling[i] == 10 && arrayBowling[i + 2] == 10 && (i % 2 == 0))
                    score += arrayBowling[i + 2] + arrayBowling[i + 4];
                else if (arrayBowling[i] == 10 && (i % 2 == 0))
                    score += arrayBowling[i + 2] + arrayBowling[i + 3];
                else if (((arrayBowling[i] + arrayBowling[i + 1]) == 10) && (i % 2 == 0))
                    score += arrayBowling[i + 2];
                

            }
            return score;

        }
    }
}
