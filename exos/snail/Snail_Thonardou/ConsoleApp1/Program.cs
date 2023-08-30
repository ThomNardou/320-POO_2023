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

            // Declaration contante
            const int POSy = 10;

            // Taille de l'écran
            int ScreenWidth = Console.WindowWidth;

            // enleve le curseur
            Console.CursorVisible = false;

            //change couleur
            Console.ForegroundColor = ConsoleColor.Red;

            Console.Write(escargot);

            for (int i = 0; i <= ScreenWidth / 2; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(i, POSy);
                Console.Write(escargot);

                if (i >= ScreenWidth / 4)
                    speed = 300;

                Thread.Sleep(speed);
            }

            Console.Clear();
            Console.SetCursorPosition(ScreenWidth / 2, POSy);
            Console.Write("____");

            Console.ReadKey();
        }
    }
}
