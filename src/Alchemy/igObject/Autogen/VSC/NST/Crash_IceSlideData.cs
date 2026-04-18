namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_IceSlideData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _IceIdle = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Collision_Material_0x30 = new();
        [FieldAttr(nst: 56)] public float _Float;
        [FieldAttr(nst: 64)] public igHandleMetaField _Collision_Material_0x40 = new();
    }
}
