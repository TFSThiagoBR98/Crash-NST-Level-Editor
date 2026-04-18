namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 112, align: 8)]
    public class igVfxRangedCurveSpawnRateData : igVfxSpawnRateData
    {
        [FieldAttr(nst: 32, ctr: 28)] public igVfxRangedCurveMetaField _rateCurve = new();
    }
}
