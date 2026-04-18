namespace Alchemy
{
    [ObjectAttr(ctr: 88, align: 8)]
    public class CLensFlareComponent : CEntityComponent
    {
        [FieldAttr(ctr: 40)] public igHandleMetaField _lensFlareGui = new();
        [FieldAttr(ctr: 48)] public igSizeTypeMetaField[] _occlusionQuery = new igSizeTypeMetaField[2];
        [FieldAttr(ctr: 64)] public EViewportID _viewportID;
        [FieldAttr(ctr: 68)] public u8 _queryIndex;
        [FieldAttr(ctr: 69)] public u8 _dirtyMask;
        [FieldAttr(ctr: 72)] public igVec3fMetaField _sunPositionViewportSpace = new();
        [FieldAttr(ctr: 84)] public float _effectStrength;
    }
}
