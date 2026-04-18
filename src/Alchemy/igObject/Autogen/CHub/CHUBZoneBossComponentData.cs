namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CHUBZoneBossComponentData : CHUBZoneComponentData
    {
        [FieldAttr(ctr: 48)] public int _trophyCountToUnlock;
        [FieldAttr(ctr: 52)] public int _keyCountToUnlock;
        [FieldAttr(ctr: 56)] public igHandleMetaField _doorHandle = new();
    }
}
