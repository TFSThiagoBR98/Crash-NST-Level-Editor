using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 16)]
    public class hkaAnimatedReferenceFrame : hkReferencedObject
    {
        public override uint Hash => 0x985e4297;

        [FieldAttr(nst: 16, ctr: 12)] public EhkaReferenceFrameTypeEnum _frameType;
    }
}