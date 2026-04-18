namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_SplineMover_NoDriftData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 44)] public bool _Bool;
        [FieldAttr(nst: 48)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect = new();
    }
}
