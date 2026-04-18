namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igBaseInputDevice : igObject
    {
        [FieldAttr(nst: 16)] public int _id = -1;
        [FieldAttr(nst: 20)] public bool _anySignalsChanged;
        [FieldAttr(nst: 24)] public igFloatList? _signals;
        [FieldAttr(nst: 32)] public igBoolList? _signalsChanged;
    }
}
