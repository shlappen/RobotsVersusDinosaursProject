using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

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
        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;

        }
        //member methods (Can Do)

        public void Attack(Dinosaur dinosaur)
        {
            SelectWeapon();
            dinosaur.health -= weapon.attackPower;
            powerLevel -= 10;
        }

        public void SelectWeapon()
        {
            Console.WriteLine("Please choose from Sword, Laser, or Asteroid");
            string response = Console.ReadLine();
            switch (response)
            {
                case "Sword":
                    weapon = new Weapon("Sword", 10);
                    break;
                case "Laser":
                    weapon = new Weapon("Laser", 25);
                    break;
                case "Asteroid":
                    weapon = new Weapon("Asteroid", 50);
                    break;
                default: Console.WriteLine("Please choose from Sword, Laser, or Asteroid");
                    break;

            }
        }
    }
}
