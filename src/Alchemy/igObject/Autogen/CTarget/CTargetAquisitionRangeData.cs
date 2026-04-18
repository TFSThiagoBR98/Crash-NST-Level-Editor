namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 4)]
    public class CTargetAquisitionRangeData : igObject
    {
        [FieldAttr(ctr: 12)] public float _forwardDistance;
        [FieldAttr(ctr: 16)] public float _backwardDistance;
    }
}
