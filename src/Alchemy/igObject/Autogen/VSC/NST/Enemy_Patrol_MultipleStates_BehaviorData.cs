namespace Alchemy
{
    [ObjectAttr(nst: 168, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Patrol_MultipleStates_BehaviorData : CVscComponentData
    {
        public enum ENewEnum11_id_fhqgj4mh
        {
            State01 = 0,
            State02 = 1,
            SwitchByTimer = 2,
            SwitchByTriggerVolume = 3,
        }

        [FieldAttr(nst: 40)] public float _WalkForwardSpeed;
        [FieldAttr(nst: 44)] public float _WalkForwardBlend;
        [FieldAttr(nst: 48)] public bool _Bool_0x30;
        [FieldAttr(nst: 52)] public ENewEnum11_id_fhqgj4mh _NewEnum11_id_fhqgj4mh;
        [FieldAttr(nst: 56)] public float _Float_0x38;
        [FieldAttr(nst: 60)] public bool _Bool_0x3c;
        [FieldAttr(nst: 61)] public bool _Bool_0x3d;
        [FieldAttr(nst: 62)] public bool _Bool_0x3e;
        [FieldAttr(nst: 63)] public bool _Bool_0x3f;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public string? _String_0x60 = null;
        [FieldAttr(nst: 104)] public string? _String_0x68 = null;
        [FieldAttr(nst: 112)] public string? _String_0x70 = null;
        [FieldAttr(nst: 120)] public bool _Bool_0x78;
        [FieldAttr(nst: 121)] public bool _Bool_0x79;
        [FieldAttr(nst: 122)] public bool _Bool_0x7a;
        [FieldAttr(nst: 123)] public bool _Bool_0x7b;
        [FieldAttr(nst: 128)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 136)] public bool _Bool_0x88;
        [FieldAttr(nst: 137)] public bool _Bool_0x89;
        [FieldAttr(nst: 140)] public float _Float_0x8c;
        [FieldAttr(nst: 144)] public igHandleMetaField _Count = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _DamagedInvulnerable = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _AkuAkuInvinciblityActive = new();
    }
}
