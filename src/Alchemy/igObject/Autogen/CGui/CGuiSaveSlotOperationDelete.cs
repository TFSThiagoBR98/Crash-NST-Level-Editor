namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 128, align: 8)]
    public class CGuiSaveSlotOperationDelete : CGuiSaveSlotOperationBase
    {
        [FieldAttr(nst: 72, ctr: 72)] public string? _deleteSaveDialogTitle = null;
        [FieldAttr(nst: 80, ctr: 80)] public string? _deleteSaveDialogBody = null;
        [FieldAttr(nst: 88, ctr: 88)] public string? _confirmDeleteOptionText = null;
        [FieldAttr(ctr: 96)] public EButtonLegendButton _confirmDeleteOptionButton;
        [FieldAttr(nst: 96, ctr: 104)] public string? _cancelDeleteOptionText = null;
        [FieldAttr(ctr: 112)] public EButtonLegendButton _cancelDeleteOptionButton;
        [FieldAttr(nst: 104, ctr: 120)] public igHandleMetaField _deleteDialogImage = new();
    }
}
