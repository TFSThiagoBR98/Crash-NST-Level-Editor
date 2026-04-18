namespace Alchemy
{
    [ObjectAttr(ctr: 112, align: 8)]
    public class CPowerCrankUpData : igObject
    {
        [FieldAttr(ctr: 12)] public igVfxRangedCurveMetaField _fillRateCurve = new();
        [FieldAttr(ctr: 96)] public float _successFillRatio;
        [FieldAttr(ctr: 100)] public float _maximumFillRatio;
        [FieldAttr(ctr: 104)] public CKartBoostData? _boostData;
    }
}
