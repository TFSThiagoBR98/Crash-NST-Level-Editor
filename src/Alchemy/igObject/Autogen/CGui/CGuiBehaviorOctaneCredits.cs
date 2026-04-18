namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CGuiBehaviorOctaneCredits : igGuiBehavior
    {
        [FieldAttr(ctr: 12)] public int _linesToClear;
        [FieldAttr(ctr: 16)] public CCreditsLineList? _credits;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _creditsList;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _characterMovieAnim;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _creditsIntroAnim;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _creditsScrollAnim;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _teamPhotoAnim;
        [FieldAttr(ctr: 64)] public CGuiListItemPopulatorOctaneCredits? _creditsPopulator;
        [FieldAttr(ctr: 72)] public int _currentLineIndex;
        [FieldAttr(ctr: 76)] public bool _creditsDone;
        [FieldAttr(ctr: 77)] public bool _photoDone;
        [FieldAttr(ctr: 78)] public bool _photoAnimStarted;
        [FieldAttr(ctr: 79)] public bool _loadingNextMap;
    }
}
