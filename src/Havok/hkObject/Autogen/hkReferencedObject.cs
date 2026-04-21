using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkReferencedObject : hkObject
    {
        public override uint Hash => 0xb70c7949;

        [FieldAttr(nst: 8, ctr: 8)] public uint _memSizeAndRefCount;
    }
}