namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class Platform_SpinningPlatformData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _ActiveTime;
        [FieldAttr(nst: 48)] public igHandleMetaField _Spin_Sfx = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Idle_Sfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Warning_Sfx = new();
        [FieldAttr(nst: 72)] public string? _Warning = null;
        [FieldAttr(nst: 80)] public string? _SpinDeath = null;
        [FieldAttr(nst: 88)] public string? _Idle = null;
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Vfx_Effect_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Vfx_Effect_0x70 = new();
    }
}
