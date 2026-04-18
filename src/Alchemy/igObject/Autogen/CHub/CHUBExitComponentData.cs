namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CHUBExitComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public EOctaneAdventureArea _nextRegionArea;
        [FieldAttr(ctr: 24)] public igHandleMetaField _minimapIconPositionEntity = new();
        [FieldAttr(ctr: 32)] public igHandleMetaField _doorEntity = new();
    }
}
