using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Versus_Dinosaurs
{
    class Dinosaur
    {
        //member variables (Has A)
        public string type;
        public int health;
        public int energy;
        public int attackPower;

        //constructor (spawner)

        public Dinosaur(string type, int attackPower)
        {
            this.type = type;
            health = 100;
            energy = 100;
            this.attackPower = attackPower;

        }
        
        //member methods (Can Do)

        public void Attack()
        {
            health -= 10;
        }
        
    }

}
