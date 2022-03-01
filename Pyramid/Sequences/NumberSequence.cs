using System;

namespace Pyramid.Sequences
{
    internal class NumberSequence : ISequence
    {
        private int _sequenceCounter;
        private readonly char[] _sequence;

        public NumberSequence()
        {
            _sequence = new char[9];
            _sequence[0] = Convert.ToChar("1");
            _sequence[1] = Convert.ToChar("2");
            _sequence[2] = Convert.ToChar("3");
            _sequence[3] = Convert.ToChar("4");
            _sequence[4] = Convert.ToChar("5");
            _sequence[5] = Convert.ToChar("6");
            _sequence[6] = Convert.ToChar("7");
            _sequence[7] = Convert.ToChar("8");
            _sequence[8] = Convert.ToChar("9");
            
            _sequenceCounter = 0;
        }

        public char GetCurrentCharacter()
        {
            var nextInSequence = _sequence[_sequenceCounter];
            return nextInSequence;
        }

        public void IncrementSequenceCharacter()
        {
            if (_sequenceCounter + 1 != _sequence.Length)
            {
                _sequenceCounter++;
            }
        }
    }
}