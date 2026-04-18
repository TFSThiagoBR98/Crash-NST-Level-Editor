namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Contact_PassthroughData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 56)] public bool _Bool_0x38;
        [FieldAttr(nst: 57)] public bool _Bool_0x39;
        [FieldAttr(nst: 58)] public bool _Bool_0x3a;
        [FieldAttr(nst: 60)] public float _Float;
        [FieldAttr(nst: 64)] public bool _Bool_0x40;
        [FieldAttr(nst: 65)] public bool _Bool_0x41;
        [FieldAttr(nst: 66)] public bool _Bool_0x42;
        [FieldAttr(nst: 67)] public bool _Bool_0x43;
        [FieldAttr(nst: 68)] public bool _Bool_0x44;
        [FieldAttr(nst: 69)] public bool _Bool_0x45;
        [FieldAttr(nst: 72)] public string? _String = null;
        [FieldAttr(nst: 80)] public bool _Bool_0x50;
        [FieldAttr(nst: 81)] public bool _Bool_0x51;
    }
}
