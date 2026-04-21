using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 208, ctr: 192)]
    public class hknpStaticCompoundShape : hknpCompoundShape
    {
        public override uint Hash => 0x4620d11c;

        [FieldAttr(nst: 192, ctr: 184)] public hknpStaticCompoundShapeData? _boundingVolumeData;
    }
}