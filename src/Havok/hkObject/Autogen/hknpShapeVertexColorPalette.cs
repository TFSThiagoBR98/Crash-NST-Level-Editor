using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 48, ctr: 48)]
    public class hknpShapeVertexColorPalette : hkReferencedObject
    {
        public override uint Hash => 0xccd7d32;

        [FieldAttr(nst: 16, ctr: 16)] public hkMemory<float> _leafShapeKeys;
        [FieldAttr(nst: 32, ctr: 32)] public hkMemory<float> _leafShapeVertexColors;
    }
}