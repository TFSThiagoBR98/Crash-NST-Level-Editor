namespace Alchemy
{
    [ObjectAttr(nst: 168, align: 8)]
    public class CGuiBehaviorDamageNumber : igGuiBehavior
    {
        [FieldAttr(nst: 16, refCount: false)] public igGuiPlaceable? _text;
        [FieldAttr(nst: 24, refCount: false)] public igGuiPlaceable? _iconPlaceable;
        [FieldAttr(nst: 32, refCount: false)] public igGuiPlaceable? _baneIconPlaceable;
        [FieldAttr(nst: 40, refCount: false)] public igGuiSprite? _icon;
        [FieldAttr(nst: 48, refCount: false)] public igGuiAnimationTag? _damageAnimation;
        [FieldAttr(nst: 56, refCount: false)] public igGuiAnimationTag? _damageFromPlayerAnimation;
        [FieldAttr(nst: 64, refCount: false)] public igGuiAnimationTag? _criticalDamageAnimation;
        [FieldAttr(nst: 72, refCount: false)] public igGuiAnimationTag? _healthAnimation;
        [FieldAttr(nst: 80, refCount: false)] public igGuiAnimationTag? _statBoostAnimation;
        [FieldAttr(nst: 88, refCount: false)] public igGuiAnimationTag? _moneyAnimation;
        [FieldAttr(nst: 96, refCount: false)] public igGuiAnimationTag? _superchargeDamageAnimation;
        [FieldAttr(nst: 104, refCount: false)] public igGuiAnimationTag? _superchargeCritcalDamageAnimation;
        [FieldAttr(nst: 112, refCount: false)] public igGuiAnimationTag? _armorBlockedAnimation;
        [FieldAttr(nst: 120)] public igNonRefCountedGuiAnimationTagList? _customAnimations;
        [FieldAttr(nst: 128)] public float _riseSpeed;
        [FieldAttr(nst: 132)] public igVec2fMetaField _screenPosition = new();
        [FieldAttr(nst: 144)] public string? _stunText = null;
        [FieldAttr(nst: 152, refCount: false)] public CGuiDamageNumberData? _damageNumberInfo;
        [FieldAttr(nst: 160)] public bool _queuedStatBoostAnimation;
    }
}
