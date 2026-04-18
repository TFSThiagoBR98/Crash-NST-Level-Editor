namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class igListenerRelativeVelocityFrameReference : igFrameReferenceBase
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVec3fMetaField _lastPosition = new();
        [FieldAttr(nst: 36, ctr: 28)] public igVec3fMetaField _lastListenerPosition = new();
    }
}
