using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Versus_Dinosaurs
{
    class Weapon
    {
        //member variables (Has A)
        public string type;
        public int attackPower;
        

        //constructor (spawner)
        public Weapon(string type, int attackPower)
        {
            this.type = type;
            this.attackPower = attackPower;
        }
        //member methods (Can Do)
    }
}
