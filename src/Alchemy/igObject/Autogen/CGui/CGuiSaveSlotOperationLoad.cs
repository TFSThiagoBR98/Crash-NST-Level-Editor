namespace Alchemy
{
    [ObjectAttr(nst: 128, ctr: 152, align: 8)]
    public class CGuiSaveSlotOperationLoad : CGuiSaveSlotOperationBase
    {
        [FieldAttr(nst: 72, ctr: 72)] public igHandleMetaField _onLoadedLevel = new();
        [FieldAttr(nst: 80, ctr: 80)] public CFadeOutPresetData? _fadePreset;
        [FieldAttr(nst: 88, ctr: 88)] public string? _loadSaveDialogTitle = null;
        [FieldAttr(nst: 96, ctr: 96)] public string? _loadSaveDialogBody = null;
        [FieldAttr(nst: 104, ctr: 104)] public string? _confirmLoadOptionText = null;
        [FieldAttr(ctr: 112)] public EButtonLegendButton _confirmLoadOptionButton;
        [FieldAttr(nst: 112, ctr: 120)] public string? _cancelLoadOptionText = null;
        [FieldAttr(ctr: 128)] public EButtonLegendButton _cancelLoadOptionButton;
        [FieldAttr(nst: 120, ctr: 136)] public igHandleMetaField _loadDialogImage = new();
        [FieldAttr(ctr: 144)] public bool _showLoadPopupInMainMenu;
    }
}
