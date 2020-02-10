using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Versus_Dinosaurs
{
    class Herd
    {
        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;
        public List<Dinosaur> Dinosaurs;
                     
        public Herd()
        {
            this.dino1 = new Dinosaur("T-Rex", 50);
            this.dino2 = new Dinosaur("Pterodactyl", 10);
            this.dino3 = new Dinosaur("Velociraptor", 25);
            //List<Dinosaur> Dinosaurs = new List<Dinosaur>();
            //Dinosaurs.Add(dino1);
            //Dinosaurs.Add(dino2);
            //Dinosaurs.Add(dino3);
        }

        public void GetDinosaur()
        {
            
        }

        
    }
}
