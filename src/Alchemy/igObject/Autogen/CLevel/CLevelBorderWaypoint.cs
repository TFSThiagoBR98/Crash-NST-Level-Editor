namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CLevelBorderWaypoint : CWaypoint
    {
        [FieldAttr(ctr: 40)] public float _topOffset;
        [FieldAttr(ctr: 44)] public float _bottomOffset;
        [FieldAttr(ctr: 48)] public igHandleMetaField _parent = new();
    }
}
