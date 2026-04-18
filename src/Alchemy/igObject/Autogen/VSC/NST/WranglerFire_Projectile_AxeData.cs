namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class WranglerFire_Projectile_AxeData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _BoltPointVariable_id_6eonfll1_variable = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _BoltPointVariable_id_cc2mfhc5_variable = new();
        [FieldAttr(nst: 56)] public float _AxeDestroyDistance;
        [FieldAttr(nst: 60)] public float _AxeReturnTime;
        [FieldAttr(nst: 64)] public float _AxeDestroyCheckUpdateTime;
        [FieldAttr(nst: 68)] public float _AxeReturnTimeLimit;
        [FieldAttr(nst: 72)] public string? _AxeCaught = null;
        [FieldAttr(nst: 80)] public string? _AxeSpawned = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Projectile_AxeThrow_Vfx_Red = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Attack_AxeThrow_Vfx_Blue = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Attack_AxeThrow_Vfx_Red = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Projectile_AxeThrow_Vfx_Blue = new();
    }
}
