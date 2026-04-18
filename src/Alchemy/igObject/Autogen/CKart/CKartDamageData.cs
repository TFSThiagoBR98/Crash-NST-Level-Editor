namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class CKartDamageData : igObject
    {
        [FieldAttr(ctr: 12)] public float _hurtDuration;
        [FieldAttr(ctr: 16)] public float _battleArenaInvulnerableStart;
        [FieldAttr(ctr: 20)] public float _battleArenaInvulnerableDuration;
        [FieldAttr(ctr: 24)] public float _minHurtDuration;
        [FieldAttr(ctr: 32)] public CKartLinearAccelerationData? _decelerationData;
        [FieldAttr(ctr: 40)] public CKartDamageAddedEffect? _addedEffect;
    }
}
