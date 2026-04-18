namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 8, meta: true)]
    public class CNovaCollisionInfo : Object
    {
        [FieldAttr(nst: 32)] public igHandleMetaField _contactEntity = new();
        [FieldAttr(nst: 40)] public igVec3fMetaField _contactPoint = new();
        [FieldAttr(nst: 52)] public igVec3fMetaField _contactNormal = new();
        [FieldAttr(nst: 64)] public igVec3fMetaField _faceNormal = new();
        [FieldAttr(nst: 80)] public CHavokRigidBodyMetaField _contactBody = new();
        [FieldAttr(nst: 96)] public uint _contactShapeKey;
        [FieldAttr(nst: 104)] public igHandleMetaField _contactMaterial = new();
        [FieldAttr(nst: 112)] public float _collisionDistance;
        [FieldAttr(nst: 116)] public bool _hitSomething;
        [FieldAttr(nst: 117)] public bool _setFaceNormal;
    }
}
