using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_my_Interfaces
{
    class Quadcopter : IFlyingRobot, IChargeable
    {
        private List<string> _components = new List<string> { "rotor1", "rotor2", "rotor3", "rotor4" };

        public string GetInfo()
        {
            return "Quadcopter: A flying and chargeable robot.";
        }

        public List<string> GetComponents()
        {
            foreach (string i in _components)
            { Console.WriteLine(i); }   // просмотр для себя

            return _components;
        }

        public void Charge()
        {
            Console.WriteLine("Charging...");
            Thread.Sleep(3000);
            Console.WriteLine("Charged!");
        }
    }
}
