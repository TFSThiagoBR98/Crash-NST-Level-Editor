namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CGuiBehaviorBattleArenaScore : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _scorePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _dualScorePlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _dualScoreSeparatorPlaceable;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _backgroundPlaceable;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _modePlaceable;
        [FieldAttr(ctr: 56)] public CRaceModeMaterialHandleTable? _iconMaterials;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _setupDualScoreAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _leadGainedAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _leadLostAnimation;
        [FieldAttr(ctr: 88)] public igGuiAnimationCategory? _leadCategory;
        [FieldAttr(ctr: 96)] public bool _hasLead;
        [FieldAttr(ctr: 100)] public EFlags _team;
        [FieldAttr(ctr: 104)] public igHandleMetaField _player = new();
    }
}
