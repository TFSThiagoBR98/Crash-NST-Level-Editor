using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 32, ctr: 32)]
    public class hknpShapeMaterialStringPalette : hkReferencedObject
    {
        public override uint Hash => 0x762f32ff;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<string> _materialNames;
    }
}