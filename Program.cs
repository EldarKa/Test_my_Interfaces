namespace Test_my_Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Quadcopter q1 = new Quadcopter();
            Console.WriteLine(q1.GetInfo());
            Console.WriteLine(q1.GetRobotType()); 
            IChargeable q2 = new Quadcopter();
            q2.Charge();
            Console.WriteLine(q2.GetInfo());

            IFlyingRobot q3 = new Quadcopter();
            Console.WriteLine(q3.GetRobotType());
            IRobot q4 = new Quadcopter();
            Console.WriteLine(q4.GetRobotType()); // интересный результат, хотя ожидаемый
        }
    }
}
