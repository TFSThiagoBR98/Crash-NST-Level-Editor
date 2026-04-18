namespace Alchemy
{
    [ObjectAttr(nst: 200, align: 4, metaType: typeof(CVscComponentData))]
    public class Castle_Enemy_Jumping_Blob_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _ActivateOnSpawn;
        [FieldAttr(nst: 41)] public bool _TrackPlayer;
        [FieldAttr(nst: 42)] public bool _SetStartingPostion;
        [FieldAttr(nst: 48)] public igHandleMetaField _TargetList = new();
        [FieldAttr(nst: 56)] public float _JumpHeight;
        [FieldAttr(nst: 60)] public float _JumpTime;
        [FieldAttr(nst: 64)] public float _PauseBetweenJumps;
        [FieldAttr(nst: 68)] public float _Range;
        [FieldAttr(nst: 72)] public int _StartingIndex;
        [FieldAttr(nst: 80)] public string? _Jump = null;
        [FieldAttr(nst: 88)] public string? _Idle = null;
        [FieldAttr(nst: 96)] public string? _Land = null;
        [FieldAttr(nst: 104)] public string? _Despawn = null;
        [FieldAttr(nst: 112)] public bool _Bool_0x70;
        [FieldAttr(nst: 120)] public string? _String_0x78 = null;
        [FieldAttr(nst: 128)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 140)] public float _Float_0x8c;
        [FieldAttr(nst: 144)] public string? _String_0x90 = null;
        [FieldAttr(nst: 152)] public igHandleMetaField _Vfx_Effect_0x98 = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _Vfx_Effect_0xa0 = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Debug_Update_Channel = new();
        [FieldAttr(nst: 176)] public float _Float_0xb0;
        [FieldAttr(nst: 180)] public float _FloatVariable_id_kxweq4ng_variable;
        [FieldAttr(nst: 184)] public bool _Bool_0xb8;
        [FieldAttr(nst: 188)] public float _Float_0xbc;
        [FieldAttr(nst: 192)] public bool _Bool_0xc0;
        [FieldAttr(nst: 193)] public bool _Bool_0xc1;
    }
}
