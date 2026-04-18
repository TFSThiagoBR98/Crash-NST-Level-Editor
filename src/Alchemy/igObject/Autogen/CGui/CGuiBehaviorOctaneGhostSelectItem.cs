namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CGuiBehaviorOctaneGhostSelectItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _ghostButtonPlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _focusAnimation;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _defocusAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _pressedSelectedAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _pressedUnselectedAnimation;
        [FieldAttr(ctr: 56)] public igHandleMetaField _ghostDriverIcon = new();
        [FieldAttr(ctr: 64)] public string? _ghostDriverName;
        [FieldAttr(ctr: 72)] public float _ghostTime;
        [FieldAttr(ctr: 76)] public bool _ghostSelected;
        [FieldAttr(ctr: 77)] public bool _isPlayerGhost;
        [FieldAttr(ctr: 80)] public CChallengeGhostHeaderData? _challengeGhost;
        [FieldAttr(ctr: 88)] public igGuiAnimationCategory? _focusCategory;
    }
}
