namespace Pyramid.Sequences
{
    internal interface ISequence
    {
        char GetCurrentCharacter();
        void IncrementSequenceCharacter();
    }
}
