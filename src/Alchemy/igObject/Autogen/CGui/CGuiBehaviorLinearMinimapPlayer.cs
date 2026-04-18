namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CGuiBehaviorLinearMinimapPlayer : CGuiBehaviorLinearMinimapIcon
    {
        [FieldAttr(ctr: 56)] public igHandleMetaField _racer = new();
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _redHitAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _greenHitAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiPlaceable? _spriteIcon;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiPlaceable? _bgSpriteIcon;
    }
}
