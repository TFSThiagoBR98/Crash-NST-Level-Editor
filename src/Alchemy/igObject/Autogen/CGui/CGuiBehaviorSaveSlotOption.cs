namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 264, align: 8)]
    public class CGuiBehaviorSaveSlotOption : CGuiBehavior
    {
        [FieldAttr(nst: 144, ctr: 144, refCount: false)] public igGuiAnimationTag? _pressAnimation;
        [FieldAttr(nst: 152, ctr: 152, refCount: false)] public igGuiAnimationTag? _onLoadAnimation;
        [FieldAttr(ctr: 160, refCount: false)] public igGuiAnimationTag? _autoSaveAnimation;
        [FieldAttr(ctr: 168, refCount: false)] public igGuiAnimationTag? _showCurrentSlotAnim;
        [FieldAttr(ctr: 176, refCount: false)] public igGuiAnimationTag? _hideCurrentSlotAnim;
        [FieldAttr(nst: 160, ctr: 184)] public EGuiMenuSound _pressSound = EGuiMenuSound.eGMS_Confirm;
        [FieldAttr(nst: 164, ctr: 188)] public int _saveSlot;
        [FieldAttr(nst: 168, ctr: 192)] public CGuiSaveSlotOperationList? _saveOperations;
        [FieldAttr(ctr: 200)] public CGuiSaveSlotOperationList? _saveOperationsEmpty;
        [FieldAttr(ctr: 208)] public CGuiSaveSlotOperationList? _inGameSaveOperations;
        [FieldAttr(ctr: 216)] public CGuiSaveSlotOperationList? _inGameSaveOperationsEmpty;
        [FieldAttr(ctr: 224, refCount: false)] public igGuiPlaceable? _currentSlotPlaceable;
        [FieldAttr(ctr: 232)] public string? _currentSlotString;
        [FieldAttr(nst: 176, ctr: 240, refCount: false)] public CGuiSaveSlotOperationBase? _currentOperation;
        [FieldAttr(ctr: 248)] public bool _isCurrentSlot;
        [FieldAttr(ctr: 256)] public CGuiSaveSlotOperationList? _currentPromptList;
    }
}
