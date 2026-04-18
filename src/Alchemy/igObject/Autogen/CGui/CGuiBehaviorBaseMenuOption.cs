namespace Alchemy
{
    [ObjectAttr(nst: 216, align: 8)]
    public class CGuiBehaviorBaseMenuOption : CGuiBehavior
    {
        public enum EMenuOptionToggleDirection
        {
            MOTD_None = 0,
            MOTD_Horizontal = 1,
            MOTD_Vertical = 2,
        }

        [FieldAttr(nst: 144, refCount: false)] public igGuiAnimationTag? _animToggle;
        [FieldAttr(nst: 152, refCount: false)] public igGuiAnimationTag? _animFailToggle;
        [FieldAttr(nst: 160, refCount: false)] public igGuiPlaceable? _labelTextPlaceable;
        [FieldAttr(nst: 168, refCount: false)] public igGuiPlaceable? _optionTextPlaceable;
        [FieldAttr(nst: 176)] public EMenuOptionToggleDirection _toggleDirection = CGuiBehaviorBaseMenuOption.EMenuOptionToggleDirection.MOTD_Horizontal;
        [FieldAttr(nst: 180)] public bool _toggleDirectionIndependent = true;
        [FieldAttr(nst: 181)] public bool _selectToggleEnabled = true;
        [FieldAttr(nst: 184, refCount: false)] public igGuiPlaceable? _decrementPlaceable;
        [FieldAttr(nst: 192, refCount: false)] public igGuiPlaceable? _incrementPlaceable;
        [FieldAttr(nst: 200)] public EGuiMenuSound _toggleSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 204)] public EGuiMenuSound _toggleFailSound;
        [FieldAttr(nst: 208)] public bool _isConfigured;
    }
}
