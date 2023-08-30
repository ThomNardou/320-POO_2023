using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Déclaration variable
            string escargot = "_@_ö";
            int speed = 200;
            int Life = 50;
            int i = 0;

            // Declaration contante
            const int POSy = 10;

            // enleve le curseur
            Console.CursorVisible = false;

            //change couleur
            Console.ForegroundColor = ConsoleColor.Red;

            Console.SetCursorPosition(i, POSy);
            Console.Write(escargot);

            while (i <= Life)
            {
                Console.MoveBufferArea(i, POSy, 4, 1, i+1, POSy);
                Thread.Sleep(speed);
                i++;
            }

            /*while (i <= Life)
            {
                Console.Clear();
                Console.SetCursorPosition(i, POSy);
                Console.Write(escargot);

                if (i >= Life / 2)
                    speed = 300;

                Thread.Sleep(speed);
                i++;
            }*/

            Console.Clear();
            Console.SetCursorPosition(i, POSy);
            Console.Write("____");

            Console.ReadKey();
        }
    }
}
