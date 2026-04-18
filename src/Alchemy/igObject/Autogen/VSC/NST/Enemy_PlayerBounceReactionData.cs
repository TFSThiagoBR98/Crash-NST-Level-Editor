namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_PlayerBounceReactionData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _HurtPlayerWhileFlipped;
        [FieldAttr(nst: 41)] public bool _HurtPlayerAfterFlipped;
        [FieldAttr(nst: 44)] public float _FlippedTimer;
        [FieldAttr(nst: 48)] public string? _BounceRecover = null;
        [FieldAttr(nst: 56)] public string? _BounceInitial = null;
        [FieldAttr(nst: 64)] public string? _BounceRecoverTell = null;
        [FieldAttr(nst: 72)] public string? _JumpBounce = null;
        [FieldAttr(nst: 80)] public string? _BounceIdle = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data_0x60 = new();
    }
}
