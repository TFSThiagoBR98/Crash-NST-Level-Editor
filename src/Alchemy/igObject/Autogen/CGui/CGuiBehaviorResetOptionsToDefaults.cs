namespace Alchemy
{
    [ObjectAttr(nst: 184, align: 8)]
    public class CGuiBehaviorResetOptionsToDefaults : CGuiBehavior
    {
        [FieldAttr(nst: 144, refCount: false)] public igGuiAnimationTag? _animPress;
        [FieldAttr(nst: 152, refCount: false)] public igGuiPlaceable? _textPlaceable;
        [FieldAttr(nst: 160)] public string? _displayText = null;
        [FieldAttr(nst: 168)] public EGuiMenuSound _pressSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 176)] public CGameVariableHandleList? _gameVariables;
    }
}
