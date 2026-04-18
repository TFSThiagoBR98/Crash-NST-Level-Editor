namespace Alchemy
{
    [ObjectAttr(nst: 216, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_HavokBased_Chase_BehaviorData : CVscComponentData
    {
        public enum ENewEnum14_id_4flii4az
        {
            Stop = 0,
            Falling = 1,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _OptionalTrigger = new();
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _SplineSnapAttachBehavior = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _SplineRotationMover = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _SplineVelocityMover = new();
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 100)] public ENewEnum14_id_4flii4az _NewEnum14_id_4flii4az;
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public float _Float_0x70;
        [FieldAttr(nst: 120)] public string? _String_0x78 = null;
        [FieldAttr(nst: 128)] public igHandleMetaField _Spline_Event_0x80 = new();
        [FieldAttr(nst: 136)] public bool _DestroyAtEnd;
        [FieldAttr(nst: 137)] public bool _Bool_0x89;
        [FieldAttr(nst: 144)] public string? _String_0x90 = null;
        [FieldAttr(nst: 152)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 160)] public bool _Bool_0xa0;
        [FieldAttr(nst: 161)] public bool _Bool_0xa1;
        [FieldAttr(nst: 164)] public float _Float_0xa4;
        [FieldAttr(nst: 168)] public string? _String_0xa8 = null;
        [FieldAttr(nst: 176)] public string? _String_0xb0 = null;
        [FieldAttr(nst: 184)] public float _Float_0xb8;
        [FieldAttr(nst: 188)] public float _Float_0xbc;
        [FieldAttr(nst: 192)] public float _Float_0xc0;
        [FieldAttr(nst: 196)] public float _Float_0xc4;
        [FieldAttr(nst: 200)] public string? _String_0xc8 = null;
        [FieldAttr(nst: 208)] public igHandleMetaField _Spline_Event_0xd0 = new();
    }
}
