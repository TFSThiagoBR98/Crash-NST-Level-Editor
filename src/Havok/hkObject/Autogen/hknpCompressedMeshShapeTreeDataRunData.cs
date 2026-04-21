using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 2, ctr: 2)]
    public class hknpCompressedMeshShapeTreeDataRunData : hkObject
    {
        public override uint Hash => 0xc253682b;

        [FieldAttr(nst: 0, ctr: 0)] public u16 _data;
    }
}