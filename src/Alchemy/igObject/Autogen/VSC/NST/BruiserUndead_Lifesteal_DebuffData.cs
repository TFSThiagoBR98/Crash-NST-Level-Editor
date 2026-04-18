namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class BruiserUndead_Lifesteal_DebuffData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _TetherAttackerBolt = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _TetherVictimBolt = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _DMG_Lifesteal_End_Data = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _DMG_LifeSteal_Data = new();
        [FieldAttr(nst: 72)] public float _MaxDistance;
        [FieldAttr(nst: 76)] public int _DamageScalar;
        [FieldAttr(nst: 80)] public igHandleMetaField _TetherVfx = new();
    }
}
