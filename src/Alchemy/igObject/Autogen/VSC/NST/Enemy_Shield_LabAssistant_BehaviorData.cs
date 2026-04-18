namespace Alchemy
{
    [ObjectAttr(nst: 224, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Shield_LabAssistant_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public float _Float_0x30;
        [FieldAttr(nst: 52)] public float _Float_0x34;
        [FieldAttr(nst: 56)] public bool _Bool_0x38;
        [FieldAttr(nst: 64)] public igHandleMetaField _Waypoint_0x40 = new();
        [FieldAttr(nst: 72)] public float _Float_0x48;
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 104)] public igHandleMetaField _Waypoint_0x68 = new();
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 120)] public string? _String_0x78 = null;
        [FieldAttr(nst: 128)] public float _Float_0x80;
        [FieldAttr(nst: 136)] public string? _String_0x88 = null;
        [FieldAttr(nst: 144)] public float _Float_0x90;
        [FieldAttr(nst: 148)] public float _Float_0x94;
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 156)] public float _Float_0x9c;
        [FieldAttr(nst: 160)] public string? _String_0xa0 = null;
        [FieldAttr(nst: 168)] public float _Float_0xa8;
        [FieldAttr(nst: 172)] public bool _Bool_0xac;
        [FieldAttr(nst: 176)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 184)] public float _Float_0xb8;
        [FieldAttr(nst: 188)] public float _Float_0xbc;
        [FieldAttr(nst: 192)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _AkuAkuInvinciblityActive = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _DamagedInvulnerable = new();
    }
}
