using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 24, ctr: 24)]
    public class hkaAnnotationTrack : hkObject
    {
        public override uint Hash => 0xd4114fdd;

        [FieldAttr(nst: 0, ctr: 0)] public string? _trackName;
        [FieldAttr(nst: 8, ctr: 8)] public hkMemory<hkaAnnotationTrackAnnotation> _annotations;
    }
}