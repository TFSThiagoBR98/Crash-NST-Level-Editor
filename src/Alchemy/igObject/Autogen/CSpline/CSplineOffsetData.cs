namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CSplineOffsetData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _minTargetOffset = 400.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _maxTargetOffset = 400.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _maxCameraOffset = 400.0f;
        [FieldAttr(nst: 28, ctr: 24)] public float _damping = 0.15f;
        [FieldAttr(nst: 32, ctr: 28)] public igVec3fMetaField _relativeDirection = new();
    }
}
