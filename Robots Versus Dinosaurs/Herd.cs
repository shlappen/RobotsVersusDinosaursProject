using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Robots_Versus_Dinosaurs
{
    class Herd
    {

        public List<Dinosaur> dinosaurs;
        public bool isDead;
        public Herd()
        {
            isDead = false;
            dinosaurs = new List<Dinosaur>
            {
                new Dinosaur("T-Rex", 50),
                new Dinosaur("Pterodactyl", 10),
                new Dinosaur("Velociraptor", 25)
            };
            
        }



        //public void SelectDinosaur()
        //{
        //    Console.WriteLine("Please choose from T-Rex, Pterodactyl, or Velociraptor.");
        //    string response = Console.ReadLine();

        //    switch (response)
        //    {
        //        case "T-Rex":
        //        Console.WriteLine("You chose T-Rex");
        //        break;
        //    case "Pterodactyl":
        //            Console.WriteLine("You chose Pterodactyl");
        //            break;
        //        case "Velociraptor":
        //            Console.WriteLine("You chose Velociraptor");
        //            break;
        //        default:
        //            break;
        //    }
        //}
        //public void PrintDinosaursInGroup(List<string> dinosaurs)
        //{
        //    foreach (string type in dinosaurs)
        //    {
        //        Console.WriteLine(type);
        //    }
        //}


    }
}
