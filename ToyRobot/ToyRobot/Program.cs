using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToyRobot.Class;

namespace ToyRobot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyToyRobot myToyRobot = new MyToyRobot();
            myToyRobot.Place(0, 0, "NORTH");
            myToyRobot.Move();
            Console.WriteLine(myToyRobot.Report());
            myToyRobot.Place(0, 0, "NORTH");
            myToyRobot.Left();
            Console.WriteLine(myToyRobot.Report());
            myToyRobot.Place(1, 2, "EAST");
            myToyRobot.Move();
            myToyRobot.Move();
            myToyRobot.Left();
            myToyRobot.Move();
            Console.WriteLine(myToyRobot.Report());
            Console.ReadKey();
        }
    }
}
