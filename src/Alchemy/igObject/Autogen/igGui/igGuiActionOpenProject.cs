namespace Alchemy
{
    [ObjectAttr(nst: 80, align: 8)]
    public class igGuiActionOpenProject : igGuiAction
    {
        [FieldAttr(nst: 48)] public igHandleMetaField _project = new();
        [FieldAttr(nst: 56)] public int _projectPriority;
        [FieldAttr(nst: 60)] public igGuiProjectParameters.EQueueType _queueBehavior;
        [FieldAttr(nst: 64)] public int _disableUnder;
        [FieldAttr(nst: 68)] public igGuiInput.EController _control = igGuiInput.EController.kController1 | igGuiInput.EController.kController2 | igGuiInput.EController.kController3 | igGuiInput.EController.kController4 | igGuiInput.EController.kController5 | igGuiInput.EController.kController6 | igGuiInput.EController.kController7 | igGuiInput.EController.kController8;
        [FieldAttr(nst: 72)] public igObject? _gameData;
    }
}
