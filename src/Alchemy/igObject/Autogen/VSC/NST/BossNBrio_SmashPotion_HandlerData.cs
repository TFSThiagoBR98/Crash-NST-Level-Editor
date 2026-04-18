namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_SmashPotion_HandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsSmashPotionEnableOnStart;
        [FieldAttr(nst: 48)] public igHandleMetaField _TriggerSmashPotionReadyTemplate = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _TriggerSmashPotionAttackTemplate = new();
        [FieldAttr(nst: 64)] public float _Float;
    }
}
