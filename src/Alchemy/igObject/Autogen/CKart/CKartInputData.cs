namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CKartInputData : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _controlSchemeGameVariableIndex = new();
        [FieldAttr(ctr: 24)] public CKartControlSchemeDataList? _controlSchemes;
        [FieldAttr(ctr: 32)] public CKartControlSchemeData? _nxSingleJoyconAlternate;
        [FieldAttr(ctr: 40)] public float _reverseAnalogThresholdOn;
        [FieldAttr(ctr: 44)] public float _reverseAnalogThresholdOff;
    }
}
