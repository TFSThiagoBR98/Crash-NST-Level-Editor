namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Fire_Projectile_On_EnterData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _ProjectileData = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public float _Float;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Vfx_Effect_0x48 = new();
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect_0x60 = new();
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Sound_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Sound_0x88 = new();
    }
}
