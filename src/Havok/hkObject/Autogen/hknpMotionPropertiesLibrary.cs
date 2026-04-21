using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 64)]
    public class hknpMotionPropertiesLibrary : hkReferencedObject
    {
        public override uint Hash => 0xc131fa71;

        [FieldAttr(nst: 16, ctr: 16)] public uint _entryAddedSignal;
        [FieldAttr(nst: 24, ctr: 24)] public uint _entryModifiedSignal;
        [FieldAttr(nst: 32, ctr: 32)] public uint _entryRemovedSignal;
        [FieldAttr(nst: 40, ctr: 40)] public uint _entries;
    }
}