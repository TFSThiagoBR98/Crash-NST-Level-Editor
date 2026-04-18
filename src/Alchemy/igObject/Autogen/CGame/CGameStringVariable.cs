namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class CGameStringVariable : CGameVariable
    {
        [FieldAttr(nst: 24, ctr: 24)] public string? _defaultValue = null;
        [FieldAttr(nst: 32, ctr: 32)] public COnGameStringVariableChangedDelegate? _onGameStringVariableChanged;
        [FieldAttr(nst: 40, ctr: 40)] public COnGameStringVariableChangedEventList? _onGameStringVariableChangedEventList;
    }
}
