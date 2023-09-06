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
        private int _x;
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

        Para Bob = new Para();

        public void addPassenger()
        {
            paraList.Add(Bob);
        }

        public void Draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, _y + i);
                Console.WriteLine(view[i]);
            }
        }

        public void MovePlaneLeft()
        {
            Console.MoveBufferArea(_x, _y, Width, height, _x + 1, _y);
        }

        public void update()
        {
            _x++;
        }
    }
}
