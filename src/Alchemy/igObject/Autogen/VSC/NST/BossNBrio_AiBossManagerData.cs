namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_AiBossManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _BossHulkTemplate = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _BossStageList = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Damage_Data = new();
    }
}
