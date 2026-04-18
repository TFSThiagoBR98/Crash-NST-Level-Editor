namespace Alchemy
{
    [ObjectAttr(nst: 216, ctr: 224, align: 8)]
    public class CGuiBehaviorBaseToggleOption : CGuiBehavior
    {
        public enum EToggleDirection
        {
            eTD_None = 0,
            eTD_Horizontal = 1,
            eTD_Vertical = 2,
        }

        [FieldAttr(nst: 144, refCount: false)] public igGuiAnimationTag? _animToggle;
        [FieldAttr(ctr: 144, refCount: false)] public igGuiAnimationTag? _animToggleLeft;
        [FieldAttr(ctr: 152, refCount: false)] public igGuiAnimationTag? _animToggleRight;
        [FieldAttr(nst: 152, ctr: 160, refCount: false)] public igGuiAnimationTag? _animFailToggle;
        [FieldAttr(ctr: 168)] public string? _onText;
        [FieldAttr(ctr: 176)] public string? _offText;
        [FieldAttr(nst: 160, ctr: 184, refCount: false)] public igGuiPlaceable? _textPlaceable;
        [FieldAttr(nst: 168, ctr: 192)] public EToggleDirection _toggleDirection = CGuiBehaviorBaseToggleOption.EToggleDirection.eTD_Horizontal;
        [FieldAttr(nst: 172, ctr: 196)] public bool _toggleDirectionIndependent = true;
        [FieldAttr(nst: 173, ctr: 197)] public bool _selectToggleEnabled = true;
        [FieldAttr(nst: 176, refCount: false)] public igGuiPlaceable? _decrementPlaceable;
        [FieldAttr(nst: 184, refCount: false)] public igGuiPlaceable? _incrementPlaceable;
        [FieldAttr(nst: 192, ctr: 200)] public EGuiMenuSound _toggleSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 196, ctr: 204)] public EGuiMenuSound _toggleFailSound;
        [FieldAttr(nst: 200, ctr: 208)] public igGuiAnimationCategory? _toggleCategory;
        [FieldAttr(nst: 208, ctr: 216)] public bool _currentValue;
        [FieldAttr(nst: 209, ctr: 217)] public bool _lastSavedValue;
    }
}
