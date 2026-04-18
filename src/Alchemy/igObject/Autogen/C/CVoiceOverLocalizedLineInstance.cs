namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 8)]
    public class CVoiceOverLocalizedLineInstance : igObject
    {
        [FieldAttr(nst: 16)] public CLocalizedLine? _localizedLine;
        [FieldAttr(nst: 24)] public igVscDelegateMetaField _started = new();
        [FieldAttr(nst: 40)] public igVscDelegateMetaField _finished = new();
        [FieldAttr(nst: 56)] public igVscDelegateMetaField _aborted = new();
        [FieldAttr(nst: 72)] public CGameSoundInstance? _gameSoundInstance;
        [FieldAttr(nst: 80)] public igHandleMetaField _subtitlesProject = new();
        [FieldAttr(nst: 88)] public CScopedScheduledFunction? _textDelay;
        [FieldAttr(nst: 96)] public COnFinishedEventList? _onFinishedEventList;
    }
}
