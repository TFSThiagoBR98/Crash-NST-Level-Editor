namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Jetski_Enemy_Basic_Seagull_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public float _Float;
        [FieldAttr(nst: 52)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 96)] public string? _String_0x60 = null;
    }
}
