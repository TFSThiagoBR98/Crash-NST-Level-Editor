namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class CGuiBehaviorButtonLegendItem : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiAnimationTag? _buttonScaleAnimation;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiAnimationTag? _buttonSelectAnimation;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igGuiAnimationTag? _mobileOnAnimation;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igGuiAnimationTag? _mobileOffAnimation;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igGuiPlaceable? _buttonTextPlaceable;
        [FieldAttr(nst: 56, ctr: 56, refCount: false)] public igGuiPlaceable? _touchButtonTextPlaceable;
        [FieldAttr(nst: 64, ctr: 64, refCount: false)] public igGuiPlaceable? _touchablePlaceable;
        [FieldAttr(nst: 72, ctr: 72)] public igGuiInput.ESignal _button;
        [FieldAttr(nst: 76, ctr: 76)] public igGuiInput.EController _touchControl;
    }
}
