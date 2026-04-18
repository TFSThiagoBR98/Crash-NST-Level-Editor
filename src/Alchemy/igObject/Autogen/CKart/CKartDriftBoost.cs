namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CKartDriftBoost : igObject
    {
        [FieldAttr(ctr: 16)] public CKartBoostData? _minBoost;
        [FieldAttr(ctr: 24)] public CKartBaseBoostData? _maxBoost;
    }
}
