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

        
        public void DinosaursTurnToAttack()
        {
            herd1.SelectDinosaur();
            //fleet.SelectRobot();
            herd1.dinosaurs[0].Attack(fleet.robots[0]);
        }

        public int Rolldice()
        {
            Random random = new Random();
            int result = random.Next(0, 2);
            return result;
        }
        public void RobotsTurnToAttack()
        {
            //fleet.SelectRobot();
            //int i = fleet.SelectRobot();
            
            int randomRobot1 = Rolldice();
            int randomRobot2 = Rolldice();
            
            fleet.robots[randomRobot1].Attack(herd1.dinosaurs[randomRobot2]);
            foreach (Dinosaur dinosaur in herd1.dinosaurs)
            { Console.WriteLine($"Type {dinosaur.type}, Health: {dinosaur.health}");
            }

            //fleet.robots.
                //Attack(herd1.dinosaurs[0]);
            //Robot.Attack(herd1.dinosaurs[1]);
            //Robot.Attack(herd1.dinosaurs[2]);
        }

        public void RunGame()
        {
            //do
            //{
            RobotsTurnToAttack();
            //Console.WriteLine(fleet.SelectRobot());
            //}while 
            //Robot.Attack(herd1.dinosaurs[0].type, );
        }
        
    }
}
