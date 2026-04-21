using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkBitField : hkObject
    {
        public override uint Hash => 0xe5dbbb9c;

        [FieldAttr(nst: 0, ctr: 0)] public hkMemory<uint> _words;
        [FieldAttr(nst: 16, ctr: 16)] public int _numBits;
    }
}