
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

            //NumberFormatInfo nfi = new NumberFormatInfo();
            //nfi.NumberDecimalSeparator = ",";
            //Console.WriteLine(nfi.NumberDecimalSeparator);

            ///////////////////////////////////////////////////////
            //Random rnd = new Random(0);
            //int x = rnd.Next(Console.WindowWidth - 1);
            //int y = rnd.Next(Console.WindowHeight - 1);


            //ConsoleKey key;
            //do
            //{

            //    Console.Clear();
            //    Console.WriteLine($"Location : {x}x{y}");
            //    Console.SetCursorPosition(x, y);
            //    Console.BackgroundColor = ConsoleColor.Blue;
            //    Console.ForegroundColor = ConsoleColor.Blue;
            //    Console.WriteLine("+");
            //    Console.ResetColor();
            //    key = Console.ReadKey(true).Key; //reading coordinate
            //    switch (key)
            //    {
            //        case ConsoleKey.W: case ConsoleKey.UpArrow: y--; break;
            //        case ConsoleKey.S: case ConsoleKey.DownArrow: y++; break;
            //        case ConsoleKey.A: case ConsoleKey.LeftArrow: x--; break;
            //        case ConsoleKey.D: case ConsoleKey.RightArrow: x++; break;

            //        default:
            //            Console.WriteLine("Error"); break;
            //    }
            //    if (x == 0) { x++; Console.Beep(); }
            //    if (y == 0) { y++; Console.Beep(); }
            //    if (x == Console.WindowWidth-1) { x--; Console.Beep(); }
            //    if (y == Console.WindowHeight-1) { y--; Console.Beep(); }
            //} while (key != ConsoleKey.Escape);

            
            
            Console.Write("Enter Expression : ");
            string expression = Console.ReadLine();
            
            //Console.WriteLine(expression);
            expression = expression.Replace(",", ".");
            string[] value = expression.Split('+', '-', '*', '/');
            // for (int i = 0; i < value.Length; i++) Console.Write(value[i] + "\t");
            //Console.WriteLine(9);
            
            double[] numbers = new double[value.Length];
            for (int i = 0; i < numbers.Length; i++) numbers[i] = Convert.ToDouble(value[i]);

            string[] operators = expression.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9');
            foreach (double i in numbers) Console.Write(i+" ");
            Console.WriteLine();
            foreach (string l in operators) Console.Write(l+"");
            Console.WriteLine();
            /*
            double a = Convert.ToDouble(value[0]);
            double b = Convert.ToDouble(value[1]);
            if (expression.Contains('+')) Console.WriteLine($" {a} + {b} = {a+b}");
           else if (expression.Contains('-')) Console.WriteLine($" {a} - {b} = {a - b}");
            else if (expression.Contains('*')) Console.WriteLine($" {a} * {b} = {a * b}");
            else if (expression.Contains('/')) Console.WriteLine($" {a} / {b} = {a / b}");
            else Console.WriteLine("You enter the wrong digit");*/





        }
    }
}
