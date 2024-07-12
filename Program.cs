using System;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.Clear();
                Console.WriteLine("P.S. Use a ',' in fractional numbers\n");
                double value1;
                double value2;
                ConsoleKey oper;

                try
                {
                    Console.WriteLine("Enter first value");
                    value1 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Enter operator");
                oper = Console.ReadKey().Key;
                Console.ReadLine();

                try
                {
                    Console.WriteLine("Enter second value");
                    value2 = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Error");
                    Console.ReadLine();
                    continue;
                }

                Console.WriteLine();

                double res = 0;
                switch (oper)
                {
                    case ConsoleKey.Multiply:
                        res = value1 * value2;
                        Console.WriteLine(value1 + " * " + value2 + " = " + res);
                        break;
                    case ConsoleKey.Add:
                        res = value1 + value2;
                        Console.WriteLine(value1 + " + " + value2 + " = " + res);
                        break;
                    case ConsoleKey.Subtract:
                        res = value1 - value2;
                        Console.WriteLine(value1 + " - " + value2 + " = " + res);
                        break;
                    case ConsoleKey.Divide:
                        if (value2 == 0) Console.WriteLine("Infinity");
                        else
                        {
                            res = value1 / value2;
                            Console.WriteLine(value1 + " / " + value2 + " = " + res);
                        }
                        break;
                    default:
                        Console.WriteLine("Error, use another operator");
                        break;
                }
                Console.ReadLine();
            }
            
        }
    }
}