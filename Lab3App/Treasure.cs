using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App
{
    public abstract class Treasure : Collectable
    {
        public int Score { get; set; }

 
        public void UpdateTotalScore()
        {
            Board.UpdateTotalScore(Score);
        }
    }
}
