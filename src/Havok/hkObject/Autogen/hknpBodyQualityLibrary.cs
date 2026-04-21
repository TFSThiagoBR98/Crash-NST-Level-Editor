using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 544, ctr: 544)]
    public class hknpBodyQualityLibrary : hkReferencedObject
    {
        public override uint Hash => 0x5f45f059;

        [FieldAttr(nst: 16, ctr: 16)] public uint _qualityModifiedSignal;
    }
}