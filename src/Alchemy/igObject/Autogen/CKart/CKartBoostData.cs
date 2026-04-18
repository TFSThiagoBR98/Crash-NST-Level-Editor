namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CKartBoostData : CKartBaseBoostData
    {
        [FieldAttr(ctr: 40)] public float _maximumSpeed;
        [FieldAttr(ctr: 44)] public float _minimumSpeed;
        [FieldAttr(ctr: 48)] public float _maximumTotalSpeed;
        [FieldAttr(ctr: 52)] public float _minimumTotalSpeed;
        [FieldAttr(ctr: 56)] public bool _startWheelie;
        [FieldAttr(ctr: 57)] public bool _cancelOnWallHit;
        [FieldAttr(ctr: 58)] public bool _cancelOnBrake;
        [FieldAttr(ctr: 59)] public bool _boostIsMaintainable;
        [FieldAttr(ctr: 60)] public bool _isABoostPad;
        [FieldAttr(ctr: 61)] public bool _canBeSuperBoost;
        [FieldAttr(ctr: 62)] public bool _isADriftBoost;
        [FieldAttr(ctr: 63)] public bool _crushOpponentOnHit;
    }
}
