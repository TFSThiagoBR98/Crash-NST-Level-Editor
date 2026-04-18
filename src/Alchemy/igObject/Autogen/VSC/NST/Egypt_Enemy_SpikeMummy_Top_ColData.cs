namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 4, metaType: typeof(CVscComponentData))]
    public class Egypt_Enemy_SpikeMummy_Top_ColData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _SpinDeath = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bolt_Point_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 72)] public float _Float;
        [FieldAttr(nst: 76)] public bool _Bool;
    }
}
