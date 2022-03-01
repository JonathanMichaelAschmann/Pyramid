namespace Pyramid.Sequences
{
    internal class AlphabetSequence : ISequence
    {
        private readonly char[] _sequence = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        private int _sequenceCounter;
        
        public AlphabetSequence()
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