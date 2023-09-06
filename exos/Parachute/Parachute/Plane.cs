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

        public void drawPassenger()
        {
            Console.SetCursorPosition(_x, _y + 7);
            for (int i = 0; i < paraList[0].withoutParachute.Length; i++)
            {
                Console.SetCursorPosition(_x, _y + i + 7);
                Console.WriteLine(paraList[0].withoutParachute[i]);
            }
        }

        public void downPassenger()
        {
            Console.SetCursorPosition(_x, _y);
        }

        public void updatePassenger()
        {
            _y++;
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
            Console.SetCursorPosition(_x, _y);
        }

        public void update()
        {
            _x++;
        }
    }
}
