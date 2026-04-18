namespace Alchemy
{
    [ObjectAttr(nst: 160, align: 8)]
    public class CGuiBehaviorButtonText : CGuiBehavior
    {
        [FieldAttr(nst: 144)] public string? _originalText = null;
        [FieldAttr(nst: 152)] public CController.EInputDeviceType _buttonDeviceType;
    }
}
