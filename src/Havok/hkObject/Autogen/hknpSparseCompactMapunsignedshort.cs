using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 40, ctr: 40)]
    public class hknpSparseCompactMapunsignedshort : hkObject
    {
        public override uint Hash => 0x4558127c;

        [FieldAttr(nst: 0, ctr: 0)] public uint _secondaryKeyMask;
        [FieldAttr(nst: 4, ctr: 4)] public uint _sencondaryKeyBits;
        [FieldAttr(nst: 8, ctr: 8)] public hkMemory<u16> _primaryKeyToIndex;
        [FieldAttr(nst: 24, ctr: 24)] public hkMemory<u16> _valueAndSecondaryKeys;
    }
}