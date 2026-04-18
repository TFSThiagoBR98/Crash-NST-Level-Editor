namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CHUBZone : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _zoneInfoHandle = new();
        [FieldAttr(ctr: 24)] public string? _zoneName;
        [FieldAttr(ctr: 32)] public string? _bossName;
        [FieldAttr(ctr: 40)] public uint _availableCollectibles;
        [FieldAttr(ctr: 48)] public igHandleMetaField _zoneEntityHandle = new();
        [FieldAttr(ctr: 56)] public EOctaneAdventureArea _adventureArea;
    }
}
