namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CHUBHintZoneComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public EOctaneAdventureHints _hubHint;
        [FieldAttr(ctr: 24)] public igHandleMetaField _playerPosition = new();
    }
}
