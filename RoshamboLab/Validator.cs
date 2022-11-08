using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    public class Validator
    {
        public static bool ValidRoshambo(string userInput)
        {
            if (userInput == "r" || userInput == "s" || userInput == "p")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
