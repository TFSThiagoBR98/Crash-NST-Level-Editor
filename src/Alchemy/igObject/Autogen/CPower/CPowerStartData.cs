namespace Alchemy
{
    [ObjectAttr(ctr: 208, align: 8)]
    public class CPowerStartData : igObject
    {
        [FieldAttr(ctr: 16)] public CPowerCrankUpDataList? _crankUpStagesData;
        [FieldAttr(ctr: 24)] public float _minimumRatioToApplyBoost;
        [FieldAttr(ctr: 28)] public igVfxRangedCurveMetaField _releaseDrainRateCurve = new();
        [FieldAttr(ctr: 112)] public float _releaseCooldownDuration;
        [FieldAttr(ctr: 116)] public igVfxRangedCurveMetaField _backfireDrainRateCurve = new();
        [FieldAttr(ctr: 200)] public float _timeAtMaximumForBackfire;
    }
}
