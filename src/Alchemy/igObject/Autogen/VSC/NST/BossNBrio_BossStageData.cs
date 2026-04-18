namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_BossStageData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _BossStageActionList = new();
        [FieldAttr(nst: 48)] public int _BossStageHitCount;
    }
}
