using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Para
    {
        private int _x;
        private int _y;

        public string[] withoutParachute =
        {
         @"     ",
         @"     ",
         @"     ",
         @"  o  ",
         @" /░\ ",
         @" / \ ",
        };

        private string[] withParachute =
        {
         @" ___ ",
         @"/|||\",
         @"\   /",
         @" \o/ ",
         @"  ░  ",
         @" / \ ",
        };

        public void drawPassenger()
        {
            Console.SetCursorPosition(_x, _y + 7);
            for (int i = 0; i < withoutParachute.Length; i++)
            {
                Console.SetCursorPosition(_x, _y + i + 7);
                Console.WriteLine(withoutParachute[i]);
            }
        }

        public void updatePassenger()
        {
            _y++;
        }

    }
}
