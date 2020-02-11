using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Robots_Versus_Dinosaurs
{
    class Fleet
    {
        public List<Robot> robots;
        public bool isDead;

        public Fleet()
        {
            isDead = false;
            robots = new List<Robot>
            {
                new Robot("Megazord"),
                new Robot("Killswitch Robocalypse"),
                new Robot("Todd")
            };
        }
    }
       


}
