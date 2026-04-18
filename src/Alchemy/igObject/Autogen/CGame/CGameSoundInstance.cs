namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class CGameSoundInstance : igObject
    {
        [FieldAttr(nst: 16)] public igHandleMetaField _soundInstance = new();
        [FieldAttr(nst: 24)] public igVscDelegateMetaField _playDelegate = new();
        [FieldAttr(nst: 40)] public igVscDelegateMetaField _stopDelegate = new();
        [FieldAttr(nst: 56)] public bool _queued;
        [FieldAttr(nst: 57)] public bool _toRemove;
        [FieldAttr(nst: 60)] public float _pendingPitch = -1.0f;
        [FieldAttr(nst: 64)] public float _pendingPitchBlendDuration;
        [FieldAttr(nst: 72)] public COnGameSoundInstancePlayEventList? _onPlayEventList;
    }
}
