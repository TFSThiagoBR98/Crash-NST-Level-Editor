namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CRacerHudComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _defaultBoostBar = new();
    }
}
