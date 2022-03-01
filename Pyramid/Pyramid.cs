using System;
using System.Collections.Generic;
using System.Linq;
using Pyramid.Sequences;

namespace Pyramid
{
    internal class Pyramid
    {
        private const char EmptySpace = '*';

        public static IEnumerable<string> CalculatePyramid(int height, ISequence sequence)
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

        public static void Draw(IEnumerable<string> input)
        {
            foreach (var row in input)
            {
                Console.WriteLine(row);
            }
        }

        public static void DrawUpsideDown(IEnumerable<string> input)
        {
            foreach (var row in input.Reverse())
            {
                Console.WriteLine(row);
            }
        }
    }
}
