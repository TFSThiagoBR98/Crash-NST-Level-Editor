namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 8)]
    public class CGuiBehaviorOctaneTeamSelectPlayerSlot : igGuiBehavior
    {
        [FieldAttr(ctr: 12)] public int _playerIndex;
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _namePlaceable;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _playerNumberText;
        [FieldAttr(ctr: 32)] public string? _playerNumberString;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiAnimationTag? _readyAnimation;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiAnimationTag? _unreadyAnimation;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiAnimationTag? _emptyAnimation;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _emptyToUnreadyAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _unreadyToEmptyAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _readyToUnreadyAnimation;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiAnimationTag? _unreadyToReadyAnimation;
        [FieldAttr(ctr: 96)] public int _teamIndex;
        [FieldAttr(ctr: 104)] public igHandleMetaField _player = new();
        [FieldAttr(ctr: 112)] public bool _ready;
        [FieldAttr(ctr: 120)] public igGuiAnimationCategory? _category;
        [FieldAttr(ctr: 128)] public igHandleMetaField _readyTable = new();
    }
}
