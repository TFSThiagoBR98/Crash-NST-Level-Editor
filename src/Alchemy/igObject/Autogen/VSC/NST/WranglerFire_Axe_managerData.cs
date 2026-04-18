namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class WranglerFire_Axe_managerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _ChargeLoop_BehaviorState = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Attack_AxeThrow_Partial = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _ThrownAxe_EntityData = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Enable_B_Attack = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Disable_B_Attack = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _ThrownAxe_ProjectileSpawnData = new();
    }
}
