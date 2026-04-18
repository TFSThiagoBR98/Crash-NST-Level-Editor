namespace Alchemy
{
    [ObjectAttr(nst: 232, align: 8)]
    public class CGuiBehaviorBaseGraphicsMenuOption : CGuiBehavior
    {
        [FieldAttr(nst: 144)] public EGraphicsMenuSettingType _settingType;
        [FieldAttr(nst: 152, refCount: false)] public igGuiAnimationTag? _animToggle;
        [FieldAttr(nst: 160, refCount: false)] public igGuiAnimationTag? _animFailToggle;
        [FieldAttr(nst: 168, refCount: false)] public igGuiPlaceable? _labelTextPlaceable;
        [FieldAttr(nst: 176, refCount: false)] public igGuiPlaceable? _optionTextPlaceable;
        [FieldAttr(nst: 184)] public CGuiBehaviorBaseMenuOption.EMenuOptionToggleDirection _toggleDirection = CGuiBehaviorBaseMenuOption.EMenuOptionToggleDirection.MOTD_Horizontal;
        [FieldAttr(nst: 188)] public bool _toggleDirectionIndependent = true;
        [FieldAttr(nst: 189)] public bool _selectToggleEnabled = true;
        [FieldAttr(nst: 192, refCount: false)] public igGuiPlaceable? _decrementPlaceable;
        [FieldAttr(nst: 200, refCount: false)] public igGuiPlaceable? _incrementPlaceable;
        [FieldAttr(nst: 208, refCount: false)] public igGuiPlaceable? _focusPlaceable;
        [FieldAttr(nst: 216)] public EGuiMenuSound _toggleSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 220)] public EGuiMenuSound _toggleFailSound;
        [FieldAttr(nst: 224)] public igGuiAnimationCategory? _toggleCategory;
    }
}
