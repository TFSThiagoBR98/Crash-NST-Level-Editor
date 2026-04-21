using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 112, ctr: 112)]
    public class hkcdStaticMeshTreeBase : hkcdStaticTreeTreehkcdStaticTreeDynamicStorage5
    {
        public override uint Hash => 0xf885dcd0;

        [FieldAttr(nst: 48, ctr: 48)] public int _numPrimitiveKeys;
        [FieldAttr(nst: 52, ctr: 52)] public int _bitsPerKey;
        [FieldAttr(nst: 56, ctr: 56)] public uint _maxKeyValue;
        [FieldAttr(nst: 64, ctr: 64)] public hkMemory<hkcdStaticMeshTreeBaseSection> _sections;
        [FieldAttr(nst: 80, ctr: 80)] public hkMemory<hkcdStaticMeshTreeBasePrimitive> _primitives;
        [FieldAttr(nst: 96, ctr: 96)] public hkMemory<u16> _sharedVerticesIndex;
    }
}