namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class CVehicleCollisionExtraResponseArenaKnockaway : CVehicleCollisionExtraResponseBase
    {
        [FieldAttr(nst: 32)] public float _minKnockawayPitch = 20.0f;
        [FieldAttr(nst: 36)] public float _maxKnockawayPitch = 90.0f;
        [FieldAttr(nst: 40)] public float _minKnockawaySpeed = 2000.0f;
        [FieldAttr(nst: 44)] public float _maxKnockawaySpeed = 5000.0f;
        [FieldAttr(nst: 48)] public bool _onDamageOnly = true;
        [FieldAttr(nst: 49)] public bool _useModifiedWeight = true;
    }
}
