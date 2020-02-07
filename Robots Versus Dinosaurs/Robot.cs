using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Versus_Dinosaurs
{
    class Robot
    {
        //member variables (Has A)
        public string name;
        public int health;
        public int powerLevel;
        public Weapon weapon;

        //constructor (spawner)
        public Robot(string name, Weapon weapon)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            this.weapon = weapon;
        }
        //member methods (Can Do)

        public void Attack()
        {

        }
    }


}
