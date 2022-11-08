using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class RockPlayer : Player
    {
        public string Name { get; set; }

        public RockPlayer()
        {
            Name = "RockPlayer";
        }
        public override Roshambo GenerateRoshambo()
        {
            Roshambo roshambo = (Roshambo)0;
            return roshambo;
        }
    }
}
