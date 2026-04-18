namespace Alchemy
{
    [ObjectAttr(ctr: 136, align: 8)]
    public class CGuiSaveSlotOperationNewGame : CGuiSaveSlotOperationBase
    {
        [FieldAttr(ctr: 72)] public string? _newGameDialogTitle;
        [FieldAttr(ctr: 80)] public string? _newGameDialogBody;
        [FieldAttr(ctr: 88)] public string? _confirmNewGameOptionText;
        [FieldAttr(ctr: 96)] public EButtonLegendButton _confirmNewGameOptionButton;
        [FieldAttr(ctr: 104)] public string? _cancelNewGameOptionText;
        [FieldAttr(ctr: 112)] public EButtonLegendButton _cancelNewGameOptionButton;
        [FieldAttr(ctr: 120)] public igHandleMetaField _newGameDialogImage = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _newGameSettingProject = new();
    }
}
