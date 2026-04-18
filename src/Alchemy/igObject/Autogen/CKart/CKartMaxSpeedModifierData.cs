namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CKartMaxSpeedModifierData : igObject
    {
        [FieldAttr(ctr: 12)] public float _maxSpeedModifier;
        [FieldAttr(ctr: 16)] public float _inAirMaxSpeedModifier;
        [FieldAttr(ctr: 20)] public bool _isTemporary;
        [FieldAttr(ctr: 21)] public bool _ignoreSlowModifiers;
        [FieldAttr(ctr: 24)] public float _duration;
        [FieldAttr(ctr: 32)] public string? _name;
    }
}
