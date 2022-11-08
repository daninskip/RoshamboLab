using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class HumanPlayer : Player
    {
        public int playerValueInt { get; private set; }
        public HumanPlayer(string nameInput)
        {
            playerName = nameInput;
        }

        public override Roshambo GenerateRoshambo(string playerValue)
        {
            switch (playerValue.ToLower())
            {
                case "r":
                    playerValueInt = 0;
                    break;
                case "p":
                    playerValueInt = 1;
                    break;
                case "s":
                    playerValueInt = 2;
                    break;

            }
            Roshambo roshambo = (Roshambo)playerValueInt;

            return roshambo;
        }
    }
}
