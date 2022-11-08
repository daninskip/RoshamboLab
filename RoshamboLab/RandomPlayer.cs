using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class RandomPlayer : Player
    {
        public string Name { get; set; }
        public RandomPlayer()
        {
            Name = "RandomPlayer";
        }
        public override Roshambo GenerateRoshambo()
        {
            Random random = new Random();
            int randomValue = random.Next(0, 2);

            Roshambo roshambo = (Roshambo)randomValue;

            return roshambo;
        }
    }
}
