namespace Alchemy
{
    [ObjectAttr(nst: 240, ctr: 240, align: 8)]
    public class CGuiBehaviorPauseMenuOptionRestart : CGuiBehaviorPauseMenuOption
    {
        [FieldAttr(nst: 200, ctr: 200)] public string? _restartString = "Restart";
        [FieldAttr(nst: 208, ctr: 208)] public string? _cancelString = "Cancel";
        [FieldAttr(nst: 216, ctr: 216)] public string? _restartDialogBodyString = "Restart the map? All unsaved progress will be lost.";
        [FieldAttr(nst: 224, ctr: 224)] public string? _restartDialogSaveDisabledBodyString = "Restart the map? All progress will be lost.";
        [FieldAttr(nst: 232, ctr: 232)] public bool _skipConfirmation;
    }
}
