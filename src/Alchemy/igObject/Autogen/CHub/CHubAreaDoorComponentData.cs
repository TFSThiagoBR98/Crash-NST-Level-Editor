namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CHubAreaDoorComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public int _keyCountToUnlock;
        [FieldAttr(ctr: 24)] public igHandleMetaField _hintPlayerPosition = new();
    }
}
