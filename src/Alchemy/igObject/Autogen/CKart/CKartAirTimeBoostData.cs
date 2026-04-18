namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartAirTimeBoostData : igObject
    {
        [FieldAttr(ctr: 12)] public float _valueMin;
        [FieldAttr(ctr: 16)] public float _valueMax;
        [FieldAttr(ctr: 20)] public igVec4ucMetaField _progressBarColor = new();
        [FieldAttr(ctr: 24)] public CKartBoostData? _boostData;
        [FieldAttr(ctr: 32)] public CKartBaseBoostData? _boostMax;
    }
}
