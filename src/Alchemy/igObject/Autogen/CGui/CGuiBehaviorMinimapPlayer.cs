namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CGuiBehaviorMinimapPlayer : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _topLevel = new();
        [FieldAttr(ctr: 24)] public igVec2fMetaField _topLeft = new();
        [FieldAttr(ctr: 32)] public igVec2fMetaField _bottomRight = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _racer = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _ghost = new();
        [FieldAttr(ctr: 56)] public ERacingMinimapDirection _racersMinimapDirection;
        [FieldAttr(ctr: 64, refCount: false)] public igGuiAnimationTag? _redHitAnimation;
        [FieldAttr(ctr: 72, refCount: false)] public igGuiAnimationTag? _greenHitAnimation;
        [FieldAttr(ctr: 80, refCount: false)] public igGuiAnimationTag? _ghostAnimation;
        [FieldAttr(ctr: 88, refCount: false)] public igGuiPlaceable? _spriteIcon;
        [FieldAttr(ctr: 96, refCount: false)] public igGuiPlaceable? _bgSpriteIcon;
    }
}
