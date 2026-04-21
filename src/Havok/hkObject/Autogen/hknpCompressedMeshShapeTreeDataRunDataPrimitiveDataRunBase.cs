using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 4, ctr: 4)]
    public class hknpCompressedMeshShapeTreeDataRunDataPrimitiveDataRunBase : hkObject
    {
        public override uint Hash => 0xad836282;

        [FieldAttr(nst: 0, ctr: 0)] public hknpCompressedMeshShapeTreeDataRunData? _value;
        [FieldAttr(nst: 2, ctr: 2)] public u8 _index;
        [FieldAttr(nst: 3, ctr: 3)] public u8 _count;
    }
}