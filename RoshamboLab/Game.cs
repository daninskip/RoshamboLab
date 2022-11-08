using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class Game
    { 
        public string RoshamboResult { get; private set; }
        public int PlayerWins { get; private set; }
        public int PlayerLoses { get; private set; }


        public string DetermineWinner(string playerRoshambo, string oppRoshambo, string playerName, string oppName, int playerWins, int playerLoses)
        {
            if (playerRoshambo == oppRoshambo)
            {
                RoshamboResult = "Draw!";
            }
            else
            {
                switch (playerRoshambo)
                {
                    case "rock":
                        if (oppRoshambo == "scissors")
                        {
                            RoshamboResult = $"{playerName} wins!";
                            PlayerWins++;
                        }
                        else
                        {
                            RoshamboResult = $"{oppName} wins!";
                            PlayerLoses++;
                        }
                        break;
                    case "paper":
                        if (oppRoshambo == "rock")
                        {
                            RoshamboResult = $"{playerName} wins!";
                            PlayerWins++;
                        }
                        else
                        {
                            RoshamboResult = $"{oppName} wins!";
                            PlayerLoses++;
                        }
                        break;
                    case "scissors":
                        if (oppRoshambo == "paper")
                        {
                            RoshamboResult = $"{playerName} wins!";
                            PlayerWins++;
                        }
                        else
                        {
                            RoshamboResult = $"{oppName} wins!";
                            PlayerLoses++;
                        }
                        break;
                }
            }
            return RoshamboResult;
        }
    }
}
