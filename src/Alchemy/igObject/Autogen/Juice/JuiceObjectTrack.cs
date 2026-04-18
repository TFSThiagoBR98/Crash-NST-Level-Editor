namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class JuiceObjectTrack : JuiceTrack
    {
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _object = new();
        [FieldAttr(nst: 48, ctr: 48)] public float _startFrameFloat;
        [FieldAttr(nst: 52, ctr: 52)] public float _endFrameFloat = -1.0f;
    }
}
