namespace Alchemy
{
    [ObjectAttr(nst: 232, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Shield_Push_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _FlippedTimer;
        [FieldAttr(nst: 44)] public float _LaunchHeight;
        [FieldAttr(nst: 48)] public float _LaunchSpeed;
        [FieldAttr(nst: 52)] public float _PushOffset;
        [FieldAttr(nst: 56)] public string? _ShieldDown = null;
        [FieldAttr(nst: 64)] public string? _WalkBack = null;
        [FieldAttr(nst: 72)] public string? _TurnBack = null;
        [FieldAttr(nst: 80)] public string? _WalkForward = null;
        [FieldAttr(nst: 88)] public string? _TurnForward = null;
        [FieldAttr(nst: 96)] public string? _ShieldUpBounce_0x60 = null;
        [FieldAttr(nst: 104)] public string? _ShieldUp = null;
        [FieldAttr(nst: 112)] public string? _ShieldUpBounce_0x70 = null;
        [FieldAttr(nst: 120)] public string? _String_0x78 = null;
        [FieldAttr(nst: 128)] public string? _String_0x80 = null;
        [FieldAttr(nst: 136)] public igHandleMetaField _Rumble_Data = new();
        [FieldAttr(nst: 144)] public int _Int;
        [FieldAttr(nst: 152)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 160)] public float _Float_0xa0;
        [FieldAttr(nst: 168)] public igHandleMetaField _Waypoint_List = new();
        [FieldAttr(nst: 176)] public string? _String_0xb0 = null;
        [FieldAttr(nst: 184)] public string? _String_0xb8 = null;
        [FieldAttr(nst: 192)] public float _Float_0xc0;
        [FieldAttr(nst: 196)] public float _Float_0xc4;
        [FieldAttr(nst: 200)] public igHandleMetaField _Game_Bool_Variable_0xc8 = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _Game_Bool_Variable_0xd0 = new();
        [FieldAttr(nst: 216)] public string? _String_0xd8 = null;
        [FieldAttr(nst: 224)] public string? _String_0xe0 = null;
    }
}
