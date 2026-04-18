namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 112, align: 8)]
    public class CGuiBehaviorSubtitles : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _textPlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _characterNamePlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _subtitlesInAnim;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _subtitlesOutAnim;
        [FieldAttr(nst: 16, ctr: 48, refCount: false)] public igGuiPlaceable? _placeable;
        [FieldAttr(nst: 24, ctr: 56)] public igStringRefList? _displayedSubtitleLines;
        [FieldAttr(ctr: 64)] public string? _characterName;
        [FieldAttr(nst: 32, ctr: 72)] public string? _currentFullSubtitleLine = null;
        [FieldAttr(nst: 40, ctr: 80)] public string? _currentPartialSubtitleLine = null;
        [FieldAttr(nst: 48, ctr: 88)] public CTimer? _textInterpolationTimer;
        [FieldAttr(nst: 56, ctr: 96)] public float _charactersPerSecond;
        [FieldAttr(nst: 60, ctr: 100)] public int _currentFullSubtitleLineLength;
        [FieldAttr(nst: 64, ctr: 104)] public int _displayedSubtitleLinesLength;
        [FieldAttr(ctr: 108)] public bool _subtitlesVisible;
    }
}
