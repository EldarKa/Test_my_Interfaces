using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_Interfaces
{
    public interface IRobot
    {
        string GetInfo() { throw new NotImplementedException(); }
        List<string> GetComponents() { throw new NotImplementedException(); }
        string GetRobotType()
        {
            return "I am a simple robot.";
        }
    }
}
