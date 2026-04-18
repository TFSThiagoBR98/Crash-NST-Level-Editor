namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class CVehicleSectionArena : CVehicleSection
    {
        [FieldAttr(nst: 72, ctr: 64)] public float _airOffsetFromSpline = 500.0f;
        [FieldAttr(nst: 76, ctr: 68)] public bool _useOverrideSpinBias;
        [FieldAttr(nst: 80, ctr: 72)] public float _landSpinBiasOverride;
    }
}
