using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Clone
{
    public class Robot : Player
    {

        public Robot(int score, int currentPick)
        {
            this.Score = score;
            this.CurrentPick = currentPick;
            this.Name = "MasterMind";
        }
    }
}
