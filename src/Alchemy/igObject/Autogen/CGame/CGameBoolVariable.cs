namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CGameBoolVariable : CGameVariable
    {
        [FieldAttr(nst: 24, ctr: 18)] public bool _defaultValue;
        [FieldAttr(nst: 32, ctr: 24)] public COnGameBoolVariableChangedDelegate? _onGameBoolVariableChanged;
        [FieldAttr(nst: 40, ctr: 32)] public COnGameBoolVariableChangeEventList? _onGameBoolVariableChangedEventList;
    }
}
