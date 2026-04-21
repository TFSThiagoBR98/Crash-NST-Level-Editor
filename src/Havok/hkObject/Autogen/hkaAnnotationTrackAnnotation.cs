using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hkaAnnotationTrackAnnotation : hkObject
    {
        public override uint Hash => 0x623bf34f;

        [FieldAttr(nst: 0, ctr: 0)] public float _time;
        [FieldAttr(nst: 8, ctr: 8)] public string? _text;
    }
}