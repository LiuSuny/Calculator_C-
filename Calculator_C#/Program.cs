//#define CHARACTER
//#define CONSOLEKEY_CHARACTER


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_C_
{
    class Program
    {
        static void Calculator ()
        {
            while (true)
            {
                Console.WriteLine("Console Calculator");
                Console.WriteLine("enter your first number : ");
                double chislo1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Maths symbol (+, -, *, /):");
                char symbol = Convert.ToChar(Console.ReadLine());

                Console.WriteLine("enter your first number:");
                double chislo2 = Convert.ToDouble(Console.ReadLine());

                double result = 0;

                switch (symbol)
                {
                    case '+':
                        result = chislo1 + chislo2;
                        break;
                    case '-':
                        result = chislo1 - chislo2;
                        break;
                    case '*':
                        result = chislo1 * chislo2;
                        break;
                    case '/':
                        if (chislo2 != 0)
                        {
                            result = chislo1 / chislo2;
                        }
                        else
                        {
                            Console.WriteLine("Dividing zero is not allow.");
                            continue;
                        }
                        break;
                    default:
                        Console.WriteLine("Error.");
                        continue;
                }

                Console.WriteLine("Result = " + result);

                Console.WriteLine("Do you want to continue calculations? (y/n)");
                string keyInput = Console.ReadLine();
                if (keyInput.ToLower() != "y")
                {
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            //Написать калькулятор, который принимает выражение вида 2 + 3, и выводит результат этого выражения:

            Calculator(); //realize our calcuator using Function



            //Below are different method of realizing ConsoleKey with Console shooter (Switch method)
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
                        Console.SetCursorPosition(30, 0);
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
        }
    }
}
