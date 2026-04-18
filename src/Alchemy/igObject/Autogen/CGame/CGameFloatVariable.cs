namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CGameFloatVariable : CGameVariable
    {
        [FieldAttr(nst: 24, ctr: 20)] public float _defaultValue;
        [FieldAttr(nst: 32, ctr: 24)] public COnGameFloatVariableChangedDelegate? _onGameFloatVariableChanged;
        [FieldAttr(nst: 40, ctr: 32)] public COnGameFloatVariableChangeEventList? _onGameFloatVariableChangedEventList;
    }
}
