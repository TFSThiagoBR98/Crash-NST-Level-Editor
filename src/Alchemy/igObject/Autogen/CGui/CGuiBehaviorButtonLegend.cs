namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CGuiBehaviorButtonLegend : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiAnimationTag? _buttonLegendScaleAnimation;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igGuiPlaceable? _buttonLegendListPlaceable;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igGuiPlaceable? _buttonLegendPlaceable;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igGuiPlaceable? _buttonLegendTextPlaceable;
        [FieldAttr(nst: 48, ctr: 48)] public bool _forceListDisplay;
        [FieldAttr(nst: 49, ctr: 49)] public bool _isVertical;
        [FieldAttr(ctr: 50)] public bool _moveToDefaultPosition;
        [FieldAttr(nst: 56, ctr: 56)] public CGuiButtonLegendTable? _workingButtonLegendData;
        [FieldAttr(nst: 64, ctr: 64)] public CGuiButtonLegendTable? _buttonLegendTable;
        [FieldAttr(nst: 72, ctr: 72)] public string? _currentButtonLegend = null;
        [FieldAttr(nst: 80, ctr: 80)] public bool _buttonLegendHasChanged = true;
        [FieldAttr(nst: 81, ctr: 81)] public bool _buttonLegendVisible = true;
        [FieldAttr(nst: 82)] public bool _buttonLegendDirty;
        [FieldAttr(nst: 84)] public CController.EInputDeviceType _buttonLegendDeviceType;
    }
}
