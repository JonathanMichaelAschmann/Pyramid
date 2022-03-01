using System;
using Pyramid.Sequences;

namespace Pyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HandleUserInput();
        }

        private static void HandleUserInput()
        {
            Console.WriteLine("How high should the pyramid be?");
            var heightInput = Console.ReadLine();

            var height = 0;
            if(!int.TryParse(heightInput, out height))
            {
                Console.WriteLine($"\r\n {heightInput} is not a valid number, try again..");
                
                HandleUserInput();
            }

            ISequence sequence = null;

            var invalid = true;
            while (invalid)
            {
                Console.WriteLine("\r\n\r\nWhich sequence should the pyramid use?");
                Console.WriteLine("A for Alphabet");
                Console.WriteLine("N for Number");
                Console.WriteLine("S for Smiley Face");

                var sequenceKey = Console.ReadKey();

                switch (sequenceKey.Key)
                {
                    case ConsoleKey.A:
                        sequence = new AlphabetSequence();
                        invalid = false;
                        break;
                    case ConsoleKey.N:
                        sequence = new NumberSequence();
                        invalid = false;
                        break;
                    case ConsoleKey.S:
                        sequence = new SmileyFaceSequence();
                        invalid = false;
                        break;
                    default:
                        Console.WriteLine($"\r\n\r\n{sequenceKey.Key} is an invalid choice! try again...");
                        break;
                }
            }

            invalid = true;
            while (invalid)
            {
                Console.WriteLine("\r\n\r\n\r\nShould the pyramid be drawn upside down?");
                Console.WriteLine("Y");
                Console.WriteLine("N");
                
                var upsideDownKey = Console.ReadKey();

                Console.WriteLine("\r\n\r\n");

                switch (upsideDownKey.Key)
                {
                    case ConsoleKey.Y:
                        Pyramid.DrawUpsideDown(Pyramid.CalculatePyramid(height, sequence));
                        invalid = false;
                        break;
                    case ConsoleKey.N:
                        Pyramid.Draw(Pyramid.CalculatePyramid(height, sequence));
                        invalid = false;
                        break;
                    default:
                        Console.WriteLine($"\r\n\r\n{upsideDownKey.Key} is an invalid choice! try again...");
                        break;
                }
            }

            invalid = true;
            while (invalid)
            {
                Console.WriteLine("\r\n\r\nDraw another?");
                Console.WriteLine("Y");
                Console.WriteLine("N");

                var drawAnotherKey = Console.ReadKey();

                Console.WriteLine("\r\n\r\n");

                switch (drawAnotherKey.Key)
                {
                    case ConsoleKey.Y:
                        HandleUserInput();
                        break;
                    case ConsoleKey.N:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine($"\r\n\r\n{drawAnotherKey.Key} is an invalid choice! try again...");
                        break;
                }
            }

            Console.Read();
        }
    }
}