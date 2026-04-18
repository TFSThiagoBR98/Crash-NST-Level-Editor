namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 128, align: 8)]
    public class CCheckpoint : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _playerStart = new();
        [FieldAttr(nst: 32, ctr: 32)] public int _chapterNumber;
        [FieldAttr(nst: 36, ctr: 36)] public bool _showUI = true;
        [FieldAttr(nst: 37, ctr: 37)] public bool _loadMapStart;
        [FieldAttr(nst: 40, ctr: 40)] public igHandleMetaField _prerequisiteStoryQuest = new();
        [FieldAttr(nst: 48, ctr: 48)] public CCheckpointEventList? _onCheckpointLoadStartedList;
        [FieldAttr(nst: 56, ctr: 56)] public CCheckpointEventDelegate? _onCheckpointLoadStarted;
        [FieldAttr(nst: 64, ctr: 64)] public CCheckpointEventList? _onCheckpointFadeOutFinishedList;
        [FieldAttr(nst: 72, ctr: 72)] public CCheckpointEventDelegate? _onCheckpointFadeOutFinished;
        [FieldAttr(nst: 80, ctr: 80)] public CCheckpointEventList? _onCheckpointFadeInStartedList;
        [FieldAttr(nst: 88, ctr: 88)] public CCheckpointEventDelegate? _onCheckpointFadeInStarted;
        [FieldAttr(nst: 96, ctr: 96)] public CCheckpointEventList? _onCheckpointLoadedList;
        [FieldAttr(nst: 104, ctr: 104)] public CCheckpointEventDelegate? _onCheckpointLoaded;
        [FieldAttr(nst: 112, ctr: 112)] public CCheckpointEventList? _onCheckpointReachedList;
        [FieldAttr(nst: 120, ctr: 120)] public CCheckpointEventDelegate? _onCheckpointReached;
    }
}
