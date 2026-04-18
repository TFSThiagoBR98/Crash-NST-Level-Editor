namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class BruiserUndead_LifeStealData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _LifeStealStates = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _ComponentDataVariable_id_5lrdvhzk_variable = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _ComponentDataVariable_id_fm49x7je_variable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _LifestealDebuffData = new();
        [FieldAttr(nst: 72)] public float _BonusHealScalar;
        [FieldAttr(nst: 76)] public float _RegularHealScalar;
        [FieldAttr(nst: 80)] public float _HealDelay;
        [FieldAttr(nst: 88)] public igHandleMetaField _FindTargets = new();
    }
}
