namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class JuiceAnimation : JuiceTrackList
    {
        [FieldAttr(nst: 40, ctr: 40)] public string? _name = null;
        [FieldAttr(nst: 48, ctr: 48)] public igHandleMetaField _scene = new();
        [FieldAttr(nst: 56, ctr: 56)] public float _lengthFloat;
        [FieldAttr(nst: 60, ctr: 60)] public bool _loop;
        [FieldAttr(nst: 64, ctr: 64)] public float _startTimeFloat;
    }
}
