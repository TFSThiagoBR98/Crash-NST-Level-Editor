namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_HulkPlatformManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _PlatformTemplate = new();
        [FieldAttr(nst: 48)] public float _PlatformSpawnHeightOffset;
        [FieldAttr(nst: 56)] public igHandleMetaField _PlatformInitialWaypointList = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _PlatformWaypointList = new();
    }
}
