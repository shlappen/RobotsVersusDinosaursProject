using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Robots_Versus_Dinosaurs
{
    class Dinosaur
    {
        //member variables (Has A)
        public string type;
        public int health;
        public int energy;
        public int attackPower;
        public bool isDead;

        //constructor (spawner)

        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            health = 100;
            energy = 100;
            this.attackPower = attackPower;
            isDead = false;
        }


        //member methods (Can Do)
        //public string GetDinosaur()
        //{
            
        //}

        public void Attack(Robot robot)
        {
            robot.health -= attackPower;
            energy -= 10;
        }
    }
}
