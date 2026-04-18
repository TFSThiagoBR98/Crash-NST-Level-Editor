namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class CPointOfInterestComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public EPointOfInterest _type;
        [FieldAttr(nst: 28, ctr: 20)] public float _range = 500.0f;
        [FieldAttr(nst: 32, ctr: 24)] public float _minimumRange = -1.0f;
        [FieldAttr(nst: 36, ctr: 28)] public int _priority = 1;
        [FieldAttr(nst: 40, ctr: 32)] public float _lookAtDelay = 0.5f;
        [FieldAttr(nst: 44, ctr: 36)] public float _lookAtDisableOnTargetLostDelay = 1.0f;
        [FieldAttr(nst: 48, ctr: 40)] public string? _requiredState = null;
        [FieldAttr(nst: 56, ctr: 48)] public igVec3fMetaField _offset = new();
        [FieldAttr(nst: 68, ctr: 60)] public bool _startDisabled;
        [FieldAttr(nst: 72, ctr: 64)] public CEntityMessage? _awareMessage;
        [FieldAttr(nst: 80, ctr: 72)] public float _chanceToRespond = 1.0f;
        [FieldAttr(nst: 84, ctr: 76)] public float _responseCooldown;
    }
}
