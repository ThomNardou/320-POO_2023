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

            List<Para> parasWhoJumped = new List<Para>();
            Para Bob = new Para();
            Para alice = new Para();
            Para TotoM = new Para();

            Plane plane = new Plane();

            plane.addPassenger(Bob);
            plane.addPassenger(TotoM);
            plane.addPassenger(alice);

            do
            {
                plane.update();
                plane.Draw();
                Thread.Sleep(100);
                Console.Clear();
               
                if (Console.KeyAvailable)
                {
                    keyPressed = Console.ReadKey(true);
                    switch(keyPressed.Key)
                    {
                        case ConsoleKey.Spacebar:
                            if (plane.paraList.Any())
                            {
                                parasWhoJumped.Add(plane.DropPara());
                            }
                            break;
                    }
                }



                foreach (Para para in parasWhoJumped)
                {
                    para.drawPassenger();
                    para.updatePassenger();
                    para.isJumping = true;
                }
            }
            while (true);
        }
    }
}
