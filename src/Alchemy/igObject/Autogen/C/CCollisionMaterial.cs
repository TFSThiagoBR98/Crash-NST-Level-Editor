namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CCollisionMaterial : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public igHandleMetaField _surfaceInfo = new();
        [FieldAttr(nst: 32, ctr: 32)] public float _dynamicFriction = 0.5f;
        [FieldAttr(nst: 36, ctr: 36)] public float _staticFriction = 0.5f;
        [FieldAttr(nst: 40, ctr: 40)] public float _restitution;
        [FieldAttr(nst: 44, ctr: 44)] public bool _isMutable;
        [FieldAttr(nst: 45, ctr: 45)] public bool _enableCollisionResponse = true;
        [FieldAttr(nst: 46, ctr: 46)] public bool _finalizeCalled;
        [FieldAttr(nst: 48, ctr: 48)] public CSurfaceVelocity? _surfaceVelocity;
        [FieldAttr(nst: 56, ctr: 56)] public uint _materialId;
    }
}
