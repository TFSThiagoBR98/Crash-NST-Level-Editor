namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 104, align: 8)]
    public class CVfxPhysicsShapeOperator : igVfxOperator
    {
        [FieldAttr(nst: 24, ctr: 16)] public CVfxPhysicsShape? _shape;
        [FieldAttr(nst: 32, ctr: 24)] public uint _collisionFlags = 287;
        [FieldAttr(nst: 36, ctr: 28)] public float _mass = 1.0f;
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _collisionMaterial = new();
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _motionProperties = new();
        [FieldAttr(nst: 56, ctr: 48)] public igVec3fMetaField _centerOfMassOffset = new();
        [FieldAttr(nst: 68, ctr: 60)] public igVec3fMetaField _localTorqueMultiplier = new();
        [FieldAttr(nst: 80, ctr: 72)] public bool _useMassAsDensity;
        [FieldAttr(nst: 81, ctr: 73)] public bool _useDebrisLayer = true;
        [FieldAttr(nst: 84, ctr: 76)] public uint _instance;
        [FieldAttr(nst: 88, ctr: 80)] public CHavokShapeMetaField _cachedShape = new();
        [FieldAttr(nst: 96, ctr: 88)] public igVec3fMetaField _cachedShapeBounds = new();
    }
}
