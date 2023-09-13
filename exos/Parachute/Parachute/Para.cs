using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachute
{
    internal class Para
    {
        public int XPos { get; set; }
        private int _yPos;

        public bool isJumping = false;
        public bool Wind = true;
        private bool parachuteIsOpen = false;
        private int randomNumber;

        private Random random = new Random();


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
            Console.ForegroundColor = ConsoleColor.Cyan;
            if (!parachuteIsOpen)
            {
                Console.SetCursorPosition(XPos, _yPos);
                for (int i = 0; i < withoutParachute.Length; i++)
                {
                    Console.SetCursorPosition(XPos, _yPos + i);
                    Console.WriteLine(withoutParachute[i]);
                }
            }
            else
            {
                //Console.SetCursorPosition(_x, _y);
                for (int i = 0; i < withParachute.Length; i++)
                {
                    Console.SetCursorPosition(XPos, _yPos + i);
                    Console.WriteLine(withParachute[i]);
                }
            }
        }

        public void updatePassenger()
        {
            if (_yPos >= Config.SCREEN_HEIGHT / 2 && _yPos < Config.SCREEN_HEIGHT - 6)
            {
                parachuteIsOpen = true;
            }
            else if (_yPos >= Config.SCREEN_HEIGHT - 6)
            {
                parachuteIsOpen= false;
            }


            if (parachuteIsOpen)
            {
                _yPos += 1;
            }
            else if (!parachuteIsOpen && _yPos < Config.SCREEN_HEIGHT - 6)
            {
                _yPos += 3;
            }
            else
            {
                _yPos += 0;
            }

            if (Wind && parachuteIsOpen)
            {
                randomNumber = random.Next(0, 3);
                XPos-= randomNumber;
            }
        }

    }
}
