//#define CHARACTER
//#define CONSOLEKEY_CHARACTER


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_C_
{
    class Program
    {
       
        static void Main(string[] args)
        {

#if CHARACTER
            char key;

            do
            {
                key = Console.ReadKey(true).KeyChar;
                Console.WriteLine((int)key + "\t" + key);
                //To know the code of our keyboard
                switch (key)
                {
                    case 'c': case 'C': Console.Clear(); break;
                    case 'w': case 'W': Console.WriteLine("Forward"); break;
                    case 's': case 'S': Console.WriteLine("Backward"); break;
                    case 'a': case 'A': Console.WriteLine("leftside"); break;
                    case 'd': case 'D': Console.WriteLine("Rightside"); break;
                    case ' ': Console.WriteLine("Jump"); break;
                    case (char)13: Console.WriteLine("Fire"); break; //13 enter
                    case (char)27: Console.WriteLine("Exit"); break; //27- escape
                    default:
                        Console.WriteLine("Error"); break;
                }

            } while (key != 27);
#endif //CHARACTER 

            //This method we use CONSOLEKEY
#if CONSOLEKEY_CHARACTER
            ConsoleKey key;

            do
            {
                key = Console.ReadKey(true).Key;
                //To know the code of our keyboard
                switch (key)
                {
                    case ConsoleKey.C: Console.Clear(); break;
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                    Console.WriteLine("Forward"); break;
                    case ConsoleKey.S: case ConsoleKey.DownArrow: Console.WriteLine("Backward"); break;
                    case ConsoleKey.A: case ConsoleKey.LeftArrow: Console.WriteLine("leftside"); break;
                    case ConsoleKey.D: case ConsoleKey.RightArrow: Console.WriteLine("Rightside"); break;
                    case ConsoleKey.Spacebar: Console.WriteLine("Jump"); break;
                    case ConsoleKey.Enter: Console.WriteLine("Fire"); break; //13 enter
                    case ConsoleKey.Escape: Console.WriteLine("Exit"); break; //27- escape
                    default:
                        Console.WriteLine("Error"); break;
                }

            } while (key != ConsoleKey.Escape); 
#endif //CONSOLEKEY_CHARACTER
            //Console.WriteLine($"Window size : {Console.WindowWidth} x{Console.WindowHeight}");
            // Console.WriteLine($"Window size : {Console.BufferWidth} x{Console.BufferHeight}");

            Random rnd = new Random(0);
            int x = rnd.Next(Console.WindowWidth - 1);
            int y = rnd.Next(Console.WindowHeight - 1);
           

            ConsoleKey key;
            do
            {
               
                Console.Clear();
                Console.WriteLine($"Location : {x}x{y}");
                Console.SetCursorPosition(x, y);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("+");
                Console.ResetColor();
                key = Console.ReadKey(true).Key; //reading coordinate
                switch (key)
                {
                    case ConsoleKey.W: case ConsoleKey.UpArrow: y--; break;
                    case ConsoleKey.S: case ConsoleKey.DownArrow: y++; break;
                    case ConsoleKey.A: case ConsoleKey.LeftArrow: x--; break;
                    case ConsoleKey.D: case ConsoleKey.RightArrow: x++; break;
     
                    default:
                        Console.WriteLine("Error"); break;
                }
                if (x == 0) { x++; Console.Beep(); }
                if (y == 0) { y++; Console.Beep(); }
                if (x == Console.WindowWidth-1) { x--; Console.Beep(); }
                if (y == Console.WindowHeight-1) { y--; Console.Beep(); }
            } while (key != ConsoleKey.Escape);












        }
    }
}
