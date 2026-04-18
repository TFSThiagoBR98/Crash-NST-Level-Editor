namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Exploding_Dynamic_ObjectData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Lifetime;
        [FieldAttr(nst: 48)] public string? _CrashDeath = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Explosion_Vfx_Effect = new();
    }
}
