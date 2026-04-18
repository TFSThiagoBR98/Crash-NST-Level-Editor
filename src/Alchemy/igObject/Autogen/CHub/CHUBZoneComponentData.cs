namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CHUBZoneComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public int _hubZoneIndex;
        [FieldAttr(ctr: 24)] public igHandleMetaField _teleporter = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _spawnPoint = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _hintPlayerPosition = new();
    }
}
