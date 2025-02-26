using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_Interfaces
{
    public interface IFlyingRobot : IRobot
    {
        string GetRobotType()
        {
            return "I am a flying robot.";   // переопределяем тип
        }
    }
}
