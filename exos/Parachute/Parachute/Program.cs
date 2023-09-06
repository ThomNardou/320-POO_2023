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

            bool isJumping = false;

            List<Para> paraListJumping = new List<Para>();

            Plane plane = new Plane();


            plane.addPassenger();

            do
            {
                if (isJumping)
                {
                    paraListJumping[0].drawPassenger();
                    paraListJumping[0].updatePassenger();
                }

                plane.Draw();
                Thread.Sleep(200);
                plane.update();
                Console.Clear();

                if (Console.KeyAvailable)
                {
                    keyPressed = Console.ReadKey(true);
                    switch(keyPressed.Key)
                    {
                        case ConsoleKey.Spacebar:
                            paraListJumping.Add(plane.paraList[0]);
                            paraListJumping[0].drawPassenger();
                            isJumping = true;
                            break;
                    }
                }
            }
            while (true);
        }
    }
}
