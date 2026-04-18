namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class BlasterTech_Vacuum_ShotData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _VacuumStates = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _ChargeEffectBoltPoint = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _ShotgunVfxBoltPoint = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _DustBunnyTag = new();
        [FieldAttr(nst: 72)] public int _DamageMultiplier;
        [FieldAttr(nst: 80)] public igHandleMetaField _ChargeEffect = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _ShotgunVfx = new();
    }
}
