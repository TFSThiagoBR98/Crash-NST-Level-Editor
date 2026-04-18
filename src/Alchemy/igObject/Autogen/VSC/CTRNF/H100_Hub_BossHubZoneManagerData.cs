namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class H100_Hub_BossHubZoneManagerData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public int _Int_0x20;
        [FieldAttr(ctr: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(ctr: 48)] public bool _Bool;
        [FieldAttr(ctr: 52)] public int _Int_0x34;
    }
}
