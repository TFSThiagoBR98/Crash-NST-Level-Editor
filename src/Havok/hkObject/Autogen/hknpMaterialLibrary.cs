using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 64)]
    public class hknpMaterialLibrary : hkReferencedObject
    {
        public override uint Hash => 0x5c07fd6a;

        [FieldAttr(nst: 16, ctr: 16)] public uint _materialAddedSignal;
        [FieldAttr(nst: 24, ctr: 24)] public uint _materialModifiedSignal;
        [FieldAttr(nst: 32, ctr: 32)] public uint _materialRemovedSignal;
        [FieldAttr(nst: 40, ctr: 40)] public uint _entries;
    }
}