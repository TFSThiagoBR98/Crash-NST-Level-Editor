namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Destroy_On_Move_CompleteData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bool_0x28;
        [FieldAttr(nst: 41)] public bool _Bool_0x29;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 72)] public string? _String = null;
        [FieldAttr(nst: 80)] public float _Float;
        [FieldAttr(nst: 84)] public bool _Bool_0x54;
    }
}
