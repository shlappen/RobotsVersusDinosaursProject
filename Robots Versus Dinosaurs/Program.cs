using System;

namespace Robots_Versus_Dinosaurs
{
    class Program
    {
        static void Main(string[] args)
        {
            Herd herd = new Herd();

            Console.WriteLine(herd.dino1.type);
            Console.ReadKey();
        }
    }
}
