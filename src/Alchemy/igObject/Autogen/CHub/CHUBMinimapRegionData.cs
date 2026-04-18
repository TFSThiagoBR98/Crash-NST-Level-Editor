namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CHUBMinimapRegionData : igObject
    {
        [FieldAttr(ctr: 12)] public igVec2fMetaField _topLeftPosition = new();
        [FieldAttr(ctr: 20)] public igVec2fMetaField _bottomRightPosition = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _regionMinimapMaterialHandle = new();
        [FieldAttr(ctr: 40)] public igVec2fMetaField _materialSize = new();
        [FieldAttr(ctr: 48)] public CEntityList? _regionZones;
    }
}
