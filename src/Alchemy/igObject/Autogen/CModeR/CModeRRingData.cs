namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CModeRRingData : igObject
    {
        [FieldAttr(ctr: 12)] public float _radius;
        [FieldAttr(ctr: 16)] public CKartBoostData? _boost;
        [FieldAttr(ctr: 24)] public float _addedTime;
    }
}
