using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Plane
    {
        public int _x;
        private int _y;



        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };


        private const int Width = 29;
        private const int height = 6;

        public List<Para> paraList = new List<Para>();


        public void addPassenger(Para person)
        {
            paraList.Add(person);
        }
        public Para DropPara()
        {

            Para paraToJump = paraList.First();
            paraList.First().XPos = _x;
            paraList.RemoveAt(0);
            return paraToJump;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, _y + i);
                Console.WriteLine(view[i]);
            }
        }

        public void update()
        {

            if (this._x > Config.SCREEN_WIDTH - 5)
            {
                this._x = 0;
            }
            else
            {
                _x += 4;
            }
        }
    }
}
