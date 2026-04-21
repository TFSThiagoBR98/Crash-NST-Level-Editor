using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 16, ctr: 16)]
    public class hknpBodyQuality : hkObject
    {
        public override uint Hash => 0x4d0fbd5b;

        [FieldAttr(nst: 0, ctr: 0)] public int _priority;
        [FieldAttr(nst: 4, ctr: 4)] public uint _supportedFlags;
        [FieldAttr(nst: 8, ctr: 8)] public uint _requestedFlags;
        [FieldAttr(nst: 12, ctr: 12)] public float _contactCachingRelativeMovementThreshold;
    }
}