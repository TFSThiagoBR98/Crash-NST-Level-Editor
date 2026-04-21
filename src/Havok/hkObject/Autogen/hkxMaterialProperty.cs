using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 8, ctr: 8)]
    public class hkxMaterialProperty : hkObject
    {
        public override uint Hash => 0xd295234d;

        [FieldAttr(nst: 0, ctr: 0)] public uint _key;
        [FieldAttr(nst: 4, ctr: 4)] public uint _value;
    }
}