using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Robots_Versus_Dinosaurs
{
    class Fleet
    {
        public List<Robot> robots;

        public Fleet()
        {
            //Robot robot1 = new Robot("Megazord");
            //Robot robot2 = new Robot("Killswitch Robocalypse");
            //Robot robot3 = new Robot("Todd");
            //robots.Add(robot1);
            //robots.Add(robot2);
            //robots.Add(robot3);
            robots = new List<Robot>
            {
                new Robot("Megazord"),
                new Robot("Killswitch Robocalypse"),
                new Robot("Todd")
            };
        }

        public void SelectRobot()
        {
            Console.WriteLine("Please choose from Megazord, Killswitch Robocalypse, or Todd.");
            string response = Console.ReadLine();
            switch (response)
            {
                case "Megazord":
                    Console.WriteLine("You chose" + robots[0].name);
                    break;
                case "Killswitch Robocalypse":
                    Console.WriteLine("You chose" + robots[1].name);
                    break;
                case "Todd":
                    Console.WriteLine("You chose" + robots[2].name);
                    break;
                default:
                    break;
            }
        }
    }
       


}
