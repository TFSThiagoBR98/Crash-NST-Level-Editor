namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Floating_Spline_Pushback_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public igVec3fMetaField _Vector3 = new();
        [FieldAttr(nst: 80)] public string? _SpinDeath = null;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public string? _String_0x60 = null;
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public igHandleMetaField _Entity_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Entity_0x78 = new();
        [FieldAttr(nst: 128)] public string? _String_0x80 = null;
        [FieldAttr(nst: 136)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 144)] public string? _String_0x90 = null;
        [FieldAttr(nst: 152)] public string? _String_0x98 = null;
        [FieldAttr(nst: 160)] public string? _String_0xa0 = null;
        [FieldAttr(nst: 168)] public string? _String_0xa8 = null;
        [FieldAttr(nst: 176)] public string? _String_0xb0 = null;
        [FieldAttr(nst: 184)] public string? _String_0xb8 = null;
    }
}
