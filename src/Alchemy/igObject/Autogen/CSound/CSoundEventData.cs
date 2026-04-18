namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 88, align: 8)]
    public class CSoundEventData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? mSound = null;
        [FieldAttr(nst: 24, ctr: 24)] public string? mAttackSound = null;
        [FieldAttr(nst: 32, ctr: 32)] public string? mRolloffSound = null;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _soundHandle = new();
        [FieldAttr(nst: 48, ctr: 48)] public igHandleMetaField _attackSoundHandle = new();
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _rolloffSoundHandle = new();
        [FieldAttr(nst: 64, ctr: 64)] public ESoundLoopEvent _loopEvent;
        [FieldAttr(nst: 68, ctr: 68)] public bool _findSoundOnThisVehicleDriver;
        [FieldAttr(nst: 72, ctr: 72)] public CSoundUpdateMethodList? _updateMethodList;
        [FieldAttr(ctr: 80)] public ELocalFilter _localFilter;
    }
}
