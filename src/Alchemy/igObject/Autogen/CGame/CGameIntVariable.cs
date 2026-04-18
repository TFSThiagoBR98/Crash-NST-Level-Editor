namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CGameIntVariable : CGameVariable
    {
        [FieldAttr(nst: 24, ctr: 20)] public int _defaultValue;
        [FieldAttr(nst: 32, ctr: 24)] public COnGameIntVariableChangedDelegate? _onGameIntVariableChanged;
        [FieldAttr(nst: 40, ctr: 32)] public COnGameIntVariableChangeEventList? _onGameIntVariableChangedEventList;
    }
}
