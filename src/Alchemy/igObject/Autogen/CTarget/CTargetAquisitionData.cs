namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CTargetAquisitionData : igObject
    {
        [FieldAttr(ctr: 12)] public float _rangeSplitAngle;
        [FieldAttr(ctr: 16)] public CTargetAquisitionRangeDataList? _ranges;
    }
}
