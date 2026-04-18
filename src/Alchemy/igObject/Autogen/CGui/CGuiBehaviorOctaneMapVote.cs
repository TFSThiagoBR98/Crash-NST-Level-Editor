namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CGuiBehaviorOctaneMapVote : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _mapNamePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _modeNamePlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _voteCountPlaceable;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _shadowIconPlaceable;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _mapSelectedAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _mapDeselectedAnimation;
        [FieldAttr(ctr: 72)] public int _mapIndex;
        [FieldAttr(ctr: 76)] public EOctaneRaceModes _raceMode;
        [FieldAttr(ctr: 80)] public string? _mapZoneName;
        [FieldAttr(ctr: 88)] public bool _isSelected;
        [FieldAttr(ctr: 96)] public igHandleMetaField _mapBackground = new();
    }
}
