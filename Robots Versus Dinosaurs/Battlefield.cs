using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;


namespace Robots_Versus_Dinosaurs
{
    class Battlefield
    {
        public Herd herd1;
        public Fleet fleet;


        public Battlefield()
        {
            herd1 = new Herd();
            fleet = new Fleet();
        }
        public int Rolldice()
        {
            Random random = new Random();
            int result = random.Next(0, 3);
            return result;
        }

        public void DinosaursTurnToAttack()
        {
            int randomDino = Rolldice();
            int randomRobot = Rolldice();

            Console.WriteLine();
            Console.WriteLine("Press enter to attack with Dinos");
            Console.ReadKey();
            Console.WriteLine();

            herd1.dinosaurs[randomDino].Attack(fleet.robots[randomRobot]);
            {
                Console.WriteLine((herd1.dinosaurs[randomDino].type) + " attacked " + (fleet.robots[randomRobot].name) + " and did " + (herd1.dinosaurs[randomDino].attackPower) + " damage!");
                Console.ReadKey();
                Console.WriteLine();

                foreach (Robot robot in fleet.robots)
                {
                    Console.WriteLine($"Name {robot.name}, Health left: {robot.health}");
                }
                Console.WriteLine();
            }
        }


        public void RobotsTurnToAttack()
        {
            Console.WriteLine("Robots' turn.");

            int randomRobot = Rolldice();
            int randomDino = Rolldice();

            fleet.robots[randomRobot].Attack(herd1.dinosaurs[randomDino]);
            Console.WriteLine((fleet.robots[randomRobot].name) + " attacked " + (herd1.dinosaurs[randomDino].type) + " and did " + (fleet.robots[randomRobot].weapon.attackPower) + " damage!");
            Console.ReadKey();
            Console.WriteLine();

            foreach (Dinosaur dinosaur in herd1.dinosaurs)
            { Console.WriteLine($"Type {dinosaur.type}, Health: {dinosaur.health}");
            }
        }

        //there has got to be a better way to do this below
        public void DeathCheck()
        {
            if (herd1.dinosaurs[0].isDead == true && herd1.dinosaurs[1].isDead == true && herd1.dinosaurs[2].isDead == true)
            {
                Console.WriteLine("Robots Win!");
                herd1.isDead = true;
            }

            if (fleet.robots[0].isDead == true && fleet.robots[1].isDead == true && fleet.robots[2].isDead == true)
            {
                fleet.isDead = true;
                Console.WriteLine("Dinos Win!");
            }
        }


        public void RunGame()
        {
            Console.WriteLine("Welcome to Robots Versus Dinosaurs");
            Console.WriteLine();
            Console.WriteLine("Dinosaurs go first");
            do
            {
                DinosaursTurnToAttack();
                RobotsTurnToAttack();
                DeathCheck();
            } while (herd1.isDead == false && fleet.isDead == false);
            Console.ReadKey();
        }
        
    }
}
