namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVelocityFrameReference : igFrameReferenceBase
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVec3fMetaField _lastPosition = new();
    }
}
