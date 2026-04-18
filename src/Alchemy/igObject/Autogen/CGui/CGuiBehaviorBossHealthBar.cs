namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 8)]
    public class CGuiBehaviorBossHealthBar : igGuiBehavior
    {
        [FieldAttr(nst: 16, refCount: false)] public igGuiAnimationTag? _healthAnimation;
        [FieldAttr(nst: 24, refCount: false)] public igGuiPlaceable? _nameText;
        [FieldAttr(nst: 32, refCount: false)] public igGuiPlaceable? _healthText;
        [FieldAttr(nst: 40, refCount: false)] public igGuiPlaceable? _portrait;
        [FieldAttr(nst: 48)] public igHandleMetaField _bossHandle = new();
        [FieldAttr(nst: 56)] public bool _fadingOut;
    }
}
