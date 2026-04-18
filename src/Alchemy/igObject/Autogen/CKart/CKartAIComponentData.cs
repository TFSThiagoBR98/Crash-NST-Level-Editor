namespace Alchemy
{
    [ObjectAttr(ctr: 32, align: 8)]
    public class CKartAIComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _driveLookAheadDistance;
        [FieldAttr(ctr: 20)] public float _driftLookAheadDistance;
        [FieldAttr(ctr: 24)] public float _smokeTestStuckCheckDuration;
    }
}
