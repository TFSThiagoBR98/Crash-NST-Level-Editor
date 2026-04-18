namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class Common_Enemy_Simple_Follow_Player_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public float _Float_0x3c;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 76)] public float _Float_0x4c;
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public bool _Bool;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 100)] public float _Float_0x64;
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 116)] public float _Float_0x74;
        [FieldAttr(nst: 120)] public igHandleMetaField _Bolt_Point = new();
    }
}
