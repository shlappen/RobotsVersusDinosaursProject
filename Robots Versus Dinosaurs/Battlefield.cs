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

        public void RobotsTurnToAttack()
        {
            fleet.SelectRobot();
            //int i = fleet.SelectRobot();
            //Robot.Attack(herd1.dinosaurs[i].SelectDinosaur());
        }

        public void RunGame()
        {
            //do
            //{
            RobotsTurnToAttack();
            //Console.WriteLine(fleet.SelectRobot());
            //}while 

        }
        
    }
}
