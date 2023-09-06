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
            Para[] myParas = new Para[3];
            Plane plane = new Plane(myParas);
            plane.Draw();

            do
            {

                plane.MovePlaneLeft();
                Thread.Sleep(100);
                plane.update();
            }
            while (true);
        }
    }
}
