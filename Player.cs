using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Clone
{
    public abstract class Player
    {
        public int Score;
        public int CurrentPick;
        public string Name;

        public Player()
        {

        }

        public void PickGesture(int pick)
        {
            this.CurrentPick = (pick - 1);
        }
    }
}
