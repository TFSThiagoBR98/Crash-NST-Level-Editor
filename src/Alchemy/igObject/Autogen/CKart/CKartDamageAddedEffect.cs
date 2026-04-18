namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class CKartDamageAddedEffect : igObject
    {
        [FieldAttr(ctr: 12)] public float _addedEffectDuration;
        [FieldAttr(ctr: 16)] public CKartMaxSpeedModifierData? _maxSpeedModifier;
    }
}
