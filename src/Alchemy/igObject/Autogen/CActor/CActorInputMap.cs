namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 4)]
    public class CActorInputMap : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _overrideMagnitude = true;
        [FieldAttr(nst: 20, ctr: 16)] public float _deadZone = 0.25f;
        [FieldAttr(nst: 24, ctr: 20)] public float _walkBlend = 0.34999999f;
        [FieldAttr(nst: 28, ctr: 24)] public float _walkCap = 0.64999998f;
        [FieldAttr(nst: 32, ctr: 28)] public float _runBlend = 0.75f;
        [FieldAttr(nst: 36, ctr: 32)] public float _walkSpeed = 0.5f;
        [FieldAttr(nst: 40, ctr: 36)] public float _runSpeed = 1.0f;
        [FieldAttr(nst: 44, ctr: 40)] public bool _overrideAngle = true;
        [FieldAttr(nst: 48, ctr: 44)] public float _movementSegmentBlend = 0.25f;
        [FieldAttr(nst: 52, ctr: 48)] public float _cardinalPrimacy = 0.6f;
        [FieldAttr(nst: 56, ctr: 52)] public float _secondaryPrimacy = 0.85f;
        [FieldAttr(nst: 60, ctr: 56)] public bool _combineLeftStickDPad = true;
    }
}
