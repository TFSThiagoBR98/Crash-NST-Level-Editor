namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartCollisionResponseComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _wallHitVelocityThreshold;
        [FieldAttr(ctr: 20)] public float _wallCancelDriftAndBoostVelocityThreshold;
        [FieldAttr(ctr: 24)] public float _wallHitProjectionThreshold;
        [FieldAttr(ctr: 28)] public float _wallHitProjectionThresholdDrift;
        [FieldAttr(ctr: 32)] public float _wallContactKeepDuration;
        [FieldAttr(ctr: 36)] public float _kartVsKartContactKeepDuration;
    }
}
