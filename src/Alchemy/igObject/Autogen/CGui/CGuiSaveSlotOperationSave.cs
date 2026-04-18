namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 128, align: 8)]
    public class CGuiSaveSlotOperationSave : CGuiSaveSlotOperationBase
    {
        [FieldAttr(nst: 72, ctr: 72)] public string? _overwriteSaveDialogTitle = null;
        [FieldAttr(nst: 80, ctr: 80)] public string? _overwriteSaveDialogBody = null;
        [FieldAttr(nst: 88, ctr: 88)] public string? _confirmOverwriteOptionText = null;
        [FieldAttr(ctr: 96)] public EButtonLegendButton _confirmOverwriteOptionButton;
        [FieldAttr(nst: 96, ctr: 104)] public string? _cancelOverwriteOptionText = null;
        [FieldAttr(ctr: 112)] public EButtonLegendButton _cancelOverwriteOptionButton;
        [FieldAttr(nst: 104, ctr: 120)] public igHandleMetaField _overwriteDialogImage = new();
    }
}
