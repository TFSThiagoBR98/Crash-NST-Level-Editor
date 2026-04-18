namespace Alchemy
{
    [ObjectAttr(nst: 24, ctr: 24, align: 4)]
    public class CSortEntitiesByWeightedVision : CSortEntities
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _angleWeightFactor = 1.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _distWeightFactor = 1.0f;
    }
}
