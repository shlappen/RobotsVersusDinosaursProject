using System;
using System.Collections.Generic;
using System.Text;

namespace Robots_Versus_Dinosaurs
{
    class Fleet
    {
        public Robot megazord;
        public Robot killswitchRobocalypse;
        public Robot todd;

        public Fleet()
        {
            megazord = new Robot("Megazord", "Sword");
            killswitchRobocalypse = new Robot("Killswitch Robocalypse", "Laser");
            todd = new Robot("Todd", "Asteroid");


        }

        public void GetRobot()
        {
            
        }

    }


}
