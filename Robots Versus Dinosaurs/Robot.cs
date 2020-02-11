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
        public bool isDead;

        //constructor (spawner)
        public Robot(string name)
        {
            this.name = name;
            health = 100;
            powerLevel = 100;
            weapon = null;
            isDead = false;
        }
        //member methods (Can Do)


        public void Attack(Dinosaur dinosaur)
        {
            SelectWeapon();
            dinosaur.health -= weapon.attackPower;
            if (dinosaur.health <= 0)
            {
                dinosaur.isDead = true;
            }
                    
        }


        public void SelectWeapon()
        {
            bool isValid = false;
            do
            {
                Console.WriteLine("Robots, choose your weapon: Sword, Laser, or Asteroid");
                string response = Console.ReadLine();
                switch (response)
                {
                    case "Sword":
                        weapon = new Weapon("Sword", 10);
                        powerLevel -= 5;
                        Console.WriteLine("How Medieval");
                        isValid = true;
                        break;
                    case "Laser":
                        weapon = new Weapon("Laser", 25);
                        powerLevel -= 15;
                        Console.WriteLine("You borrowed a laser from a shark!");
                        isValid = true;
                        break;
                    case "Asteroid":

                        weapon = new Weapon("Asteroid", 50);
                        powerLevel -= 20;
                        Console.WriteLine("...");
                        isValid = true;
                        break;
                    default:
                        Console.WriteLine("Please choose from Sword, Laser, or Asteroid");
                        break;

                }

            } while (isValid == false);
        }
    }
}
