namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 120, align: 8)]
    public class CGameSoundMusicSettings : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _audition;
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _nextStream = new();
        [FieldAttr(nst: 32, ctr: 24)] public CWeightedSoundList? _variableNextStream;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _stinger1 = new();
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _stinger2 = new();
        [FieldAttr(nst: 56, ctr: 48)] public bool _flipStreams;
        [FieldAttr(nst: 60, ctr: 52)] public float _fadeTime = 1.0f;
        [FieldAttr(nst: 64, ctr: 56)] public EInterleavedMusicState _interleavedState = EInterleavedMusicState.eIMS_Traversal;
        [FieldAttr(nst: 68, ctr: 60)] public ECombatMusicIntensity _combatMusicIntensity;
        [FieldAttr(nst: 72, ctr: 64)] public igHandleMetaField _mix = new();
        [FieldAttr(nst: 80, ctr: 72)] public bool _waitForOppositeStreamStopped;
        [FieldAttr(nst: 81, ctr: 73)] public bool _disableTraversalMovementMix;
        [FieldAttr(nst: 84, ctr: 76)] public float _newStinger1SyncTimeInSeconds;
        [FieldAttr(nst: 88, ctr: 80)] public float _newStinger2SyncTimeInSeconds;
        [FieldAttr(nst: 92, ctr: 84)] public float _nextMusicBeatsPerMinute = 100.0f;
        [FieldAttr(nst: 96, ctr: 88)] public int _nextMusicBeatsPerMeasure = 4;
        [FieldAttr(nst: 100, ctr: 92)] public int _syncToMusicMaxBeatsToWait = 4;
        [FieldAttr(nst: 104, ctr: 96)] public bool _syncToTempo;
        [FieldAttr(nst: 112, ctr: 104)] public CGameSoundMusicEventPatternList? _eventList;
        [FieldAttr(nst: 120, ctr: 112)] public uint _priority = 4294967295;
    }
}
