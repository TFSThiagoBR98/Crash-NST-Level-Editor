namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class igGuiProjectParameters : igObject
    {
        public enum EQueueType
        {
            kQueueNone = 0,
            kQueueRegular = 1,
            kQueueOne = 2,
        }

        [FieldAttr(nst: 16)] public igGuiInput.EController _inputControl = igGuiInput.EController.kController1 | igGuiInput.EController.kController2 | igGuiInput.EController.kController3 | igGuiInput.EController.kController4 | igGuiInput.EController.kController5 | igGuiInput.EController.kController6 | igGuiInput.EController.kController7 | igGuiInput.EController.kController8;
        [FieldAttr(nst: 20)] public int _priority;
        [FieldAttr(nst: 24)] public int _disableUnder;
        [FieldAttr(nst: 28)] public EQueueType _queueBehavior;
        [FieldAttr(nst: 32)] public bool _onSubScreen;
        [FieldAttr(nst: 40, refCount: false)] public igObject? _gameData;
    }
}
