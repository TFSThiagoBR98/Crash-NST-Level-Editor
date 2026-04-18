namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CSwitchCounter : igObject
    {
        [FieldAttr(nst: 16)] public int _currentValue;
        [FieldAttr(nst: 20)] public int _maxValue;
        [FieldAttr(nst: 24)] public bool _looping;
    }
}
