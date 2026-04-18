namespace Alchemy
{
    [ObjectAttr(ctr: 256, align: 8)]
    public class CKartWheelVisualData : igNamedObject
    {
        [FieldAttr(ctr: 24)] public CKartWheelGroundMatcherData? _groundMatcherData;
        [FieldAttr(ctr: 32)] public igVec3fMetaField _queryStart = new();
        [FieldAttr(ctr: 44)] public float _queryLength;
        [FieldAttr(ctr: 48)] public uint _collisionFlags;
        [FieldAttr(ctr: 56)] public CCylinderShape? _wheelShape;
        [FieldAttr(ctr: 64)] public igVfxRangedCurveMetaField _upwardMovementCurve = new();
        [FieldAttr(ctr: 148)] public igVfxRangedCurveMetaField _downwardMovementCurve = new();
        [FieldAttr(ctr: 232)] public igHandleMetaField _matchingKartWheelFakeBoltPoint = new();
        [FieldAttr(ctr: 240)] public float _maxAccumulationDistance;
        [FieldAttr(ctr: 244)] public bool _flipSideAxis;
        [FieldAttr(ctr: 245)] public bool _debug;
        [FieldAttr(ctr: 248)] public int _dirtyCount;
    }
}
