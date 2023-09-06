using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Config.SCREEN_WIDTH, Config.SCREEN_HEIGHT);
            ConsoleKeyInfo keyPressed;

            int intTemp = 0;

            Plane plane = new Plane();


            plane.addPassenger();

            do
            {

                plane.Draw();
                plane.MovePlaneLeft();
                Thread.Sleep(200);
                plane.update();
                Console.Clear();

                if (Console.KeyAvailable)
                {
                    keyPressed = Console.ReadKey(true);
                    switch(keyPressed.Key)
                    {
                        case ConsoleKey.Spacebar:
                            plane.drawPassenger();
                            break;
                    }
                }
            }
            while (true);
        }
    }
}
