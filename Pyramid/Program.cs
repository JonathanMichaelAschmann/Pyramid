using System;
using System.Collections.Generic;
using System.Linq;
using Pyramid.Sequences;

namespace Pyramid
{
    internal class Program
    {
        private const char EmptySpace = '*';

        static void Main(string[] args)
        {
            Draw(CalculatePyramid(28, new AlphabetSequence()));
            Console.WriteLine(string.Empty);
            Draw(CalculatePyramid(12, new NumberSequence()));
            Console.WriteLine(string.Empty);
            DrawUpsideDown(CalculatePyramid(10, new SmileyFaceSequence()));

            Console.Read();
        }

        private static IEnumerable<string> CalculatePyramid(int height, ISequence sequence)
        {
            var result = new List<string>();
            var counter = 1;

            for (var h = 1; h < height + 1; h++)
            {
                var row = String.Empty;
                for (var x = 0; x < height - h; x++)
                {
                    row += EmptySpace.ToString();
                }
                for (var x = 0; x < counter; x++)
                {
                    row += sequence.GetCurrentCharacter();
                }
                for (var x = 0; x < height - h; x++)
                {
                    row += EmptySpace.ToString();
                }

                counter += 2;
                sequence.IncrementSequenceCharacter();
                result.Add(row);
            }

            return result;
        }

        private static void Draw(IEnumerable<string> input)
        {
            foreach (var row in input)
            {
                Console.WriteLine(row);
            }
        }

        private static void DrawUpsideDown(IEnumerable<string> input)
        {
            foreach (var row in input.Reverse())
            {
                Console.WriteLine(row);
            }
        }
    }
}