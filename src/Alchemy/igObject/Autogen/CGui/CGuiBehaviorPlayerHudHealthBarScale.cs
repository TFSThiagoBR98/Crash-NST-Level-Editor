namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 8)]
    public class CGuiBehaviorPlayerHudHealthBarScale : igGuiBehavior
    {
        [FieldAttr(nst: 16)] public bool _displayVehicleShields;
        [FieldAttr(nst: 24, refCount: false)] public igGuiAnimationTag? _healthBarScaleAnimation;
        [FieldAttr(nst: 32)] public igGuiAnimationCategory? _healthBarScaleCategory;
        [FieldAttr(nst: 40)] public igRangedFloatMetaField _healthBarScaleAnimationTimeRange = new();
        [FieldAttr(nst: 48)] public float _healthBarDangerThreshold = 0.2f;
        [FieldAttr(nst: 56, refCount: false)] public igGuiAnimationTag? _healthBarDangerAnimation;
        [FieldAttr(nst: 64)] public igGuiAnimationCategory? _healthBarDangerCategory;
        [FieldAttr(nst: 72, refCount: false)] public igGuiAnimationTag? _vehicleShieldRecover;
        [FieldAttr(nst: 80)] public igGuiAnimationCategory? _vehicleShieldCategory;
        [FieldAttr(nst: 88)] public EPlayerId _player = EPlayerId.EPLAYERID_NONE;
        [FieldAttr(nst: 92)] public bool _playingDangerAnimation;
        [FieldAttr(nst: 93)] public bool _fakeZeroHealth;
        [FieldAttr(nst: 96)] public float _lastAnimTime = -1.0f;
    }
}
