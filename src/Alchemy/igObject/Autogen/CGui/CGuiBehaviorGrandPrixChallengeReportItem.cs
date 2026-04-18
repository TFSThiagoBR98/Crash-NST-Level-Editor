namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGuiBehaviorGrandPrixChallengeReportItem : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _nitroPointPlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiAnimationTag? _awardAnimation;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _outAnimation;
        [FieldAttr(ctr: 48)] public igGuiAnimationCategory? _animCategory;
        [FieldAttr(ctr: 56)] public uint _achievementId;
        [FieldAttr(ctr: 60)] public int _nitroPoints;
        [FieldAttr(ctr: 64)] public bool _animOutFinished;
        [FieldAttr(ctr: 65)] public bool _animOutPlaying;
        [FieldAttr(ctr: 66)] public bool _animInPlaying;
    }
}
