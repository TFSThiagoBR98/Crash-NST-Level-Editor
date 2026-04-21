using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 56, ctr: 56)]
    public class hkaAnimation : hkReferencedObject
    {
        public override uint Hash => 0xb545fe18;

        [FieldAttr(nst: 16, ctr: 12)] public EAnimationType _type;
        [FieldAttr(nst: 20, ctr: 16)] public float _duration;
        [FieldAttr(nst: 24, ctr: 20)] public int _numberOfTransformTracks;
        [FieldAttr(nst: 28, ctr: 24)] public int _numberOfFloatTracks;
        [FieldAttr(nst: 32, ctr: 32)] public hkaAnimatedReferenceFrame? _extractedMotion;
        [FieldAttr(nst: 40, ctr: 40)] public hkMemory<hkaAnnotationTrack> _annotationTracks;
    }
}