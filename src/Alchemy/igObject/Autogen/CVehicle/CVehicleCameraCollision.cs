namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CVehicleCameraCollision : igObject
    {
        [FieldAttr(nst: 16)] public float collisionOutDampingFactor = 0.05f;
        [FieldAttr(nst: 20)] public float _rayWidth = 20.0f;
        [FieldAttr(nst: 24)] public bool _enabled = true;
        [FieldAttr(nst: 25)] public bool _debug;
        [FieldAttr(nst: 32)] public CCollisionMaterialHandleList? _ignoreCollisionMaterialsList;
        [FieldAttr(nst: 40)] public float _collisionOutVelocity;
        [FieldAttr(nst: 44)] public float _lastCollisionFraction = 1.0f;
    }
}
