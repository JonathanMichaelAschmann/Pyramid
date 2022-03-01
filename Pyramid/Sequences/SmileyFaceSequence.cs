using System;

namespace Pyramid.Sequences
{
    internal class SmileyFaceSequence : ISequence
    {
        private int _sequenceCounter;
        private readonly char[] _sequence = { (char)1 };

        public SmileyFaceSequence()
        {
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