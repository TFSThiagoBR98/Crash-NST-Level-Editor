namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class common_GemDoorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public int _Int;
        [FieldAttr(nst: 48)] public igHandleMetaField _GemGameVariable = new();
        [FieldAttr(nst: 56)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 68)] public float _Float;
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Sound_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect_0x60 = new();
    }
}
