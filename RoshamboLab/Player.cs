using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public abstract class Player
    {
        public string playerName { get; protected set; }
        public string roshamboValue { get; protected set; }

    
        public virtual Roshambo GenerateRoshambo()
        {
            Roshambo roshambo = (Roshambo)0;
            return  roshambo;
        }

        public virtual Roshambo GenerateRoshambo(string playerValue)
        {
            Roshambo roshambo = (Roshambo)0;
            return roshambo;
        }

       
    }

}
