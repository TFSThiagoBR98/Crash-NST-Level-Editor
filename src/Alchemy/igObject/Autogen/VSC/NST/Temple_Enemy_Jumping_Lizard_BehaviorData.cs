namespace Alchemy
{
    [ObjectAttr(nst: 176, align: 4, metaType: typeof(CVscComponentData))]
    public class Temple_Enemy_Jumping_Lizard_BehaviorData : CVscComponentData
    {
        public enum EStartingDirection
        {
            CountUp = 0,
            CountDown = 1,
        }

        [FieldAttr(nst: 40)] public bool _TrackPlayer;
        [FieldAttr(nst: 41)] public bool _SetStartingPostion;
        [FieldAttr(nst: 48)] public igHandleMetaField _TargetList = new();
        [FieldAttr(nst: 56)] public EStartingDirection _StartingDirection;
        [FieldAttr(nst: 60)] public float _JumpHeight;
        [FieldAttr(nst: 64)] public float _JumpDuration;
        [FieldAttr(nst: 68)] public float _PauseBetweenJumps;
        [FieldAttr(nst: 72)] public int _StartingIndex;
        [FieldAttr(nst: 80)] public string? _Jump_0x50 = null;
        [FieldAttr(nst: 88)] public string? _Idle = null;
        [FieldAttr(nst: 96)] public string? _Land = null;
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 108)] public float _Float_0x6c;
        [FieldAttr(nst: 112)] public string? _String_0x70 = null;
        [FieldAttr(nst: 120)] public float _Float_0x78;
        [FieldAttr(nst: 124)] public float _Float_0x7c;
        [FieldAttr(nst: 128)] public string? _Jump_0x80 = null;
        [FieldAttr(nst: 136)] public float _Range;
        [FieldAttr(nst: 140)] public bool _Bool_0x8c;
        [FieldAttr(nst: 144)] public string? _String_0x90 = null;
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 156)] public bool _Bool_0x9c;
        [FieldAttr(nst: 157)] public bool _Bool_0x9d;
        [FieldAttr(nst: 160)] public string? _Jump_0xa0 = null;
        [FieldAttr(nst: 168)] public float _Float_0xa8;
        [FieldAttr(nst: 172)] public float _Float_0xac;
    }
}
