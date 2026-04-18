namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 104, align: 8)]
    public class CGuiBehaviorInfoMessage : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiPlaceable? _infoMessageText;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiAnimationTag? _fadeInAnimation;
        [FieldAttr(nst: 32)] public CGuiEventInfoMessage.EInfoMessageState _activeInfoState;
        [FieldAttr(nst: 40, ctr: 32)] public string? _loadingText = null;
        [FieldAttr(nst: 48, ctr: 40)] public string? _pressToSkip = null;
        [FieldAttr(nst: 56, ctr: 48)] public string? _tapToSkip = null;
        [FieldAttr(nst: 64, ctr: 56)] public string? _waitToSkip = null;
        [FieldAttr(ctr: 64)] public string? _skipped_WaitingForOthers;
        [FieldAttr(nst: 72, ctr: 72)] public string? _pausedText = null;
        [FieldAttr(nst: 80, ctr: 80)] public float _infoMessageDelay = 3.0f;
        [FieldAttr(nst: 88, ctr: 88)] public igVscDelegateMetaField _skipDelegate = new();
    }
}
