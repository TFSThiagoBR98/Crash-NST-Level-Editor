namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 4)]
    public class CHavokLinearCastQueryParameters : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public uint _collisionFlags = 31;
        [FieldAttr(nst: 20, ctr: 16)] public float _radius = 1.0f;
        [FieldAttr(nst: 24, ctr: 20)] public int _maxResults = 1;
        [FieldAttr(nst: 28, ctr: 24)] public bool _ignoreSourceEntityCollision = true;
        [FieldAttr(nst: 29, ctr: 25)] public bool _alwaysFindClosestHit = true;
        [FieldAttr(nst: 30, ctr: 26)] public bool _oneHitPerBody;
        [FieldAttr(nst: 31, ctr: 27)] public bool _ignoreNoCollide;
        [FieldAttr(nst: 32, ctr: 28)] public bool _useSourceEntityCollisionShape;
        [FieldAttr(nst: 33, ctr: 29)] public bool _useSourceEntityCollisionFiltering;
        [FieldAttr(nst: 34, ctr: 30)] public bool _useSourceEntityCollisionFilterAsMask;
        [FieldAttr(nst: 35, ctr: 31)] public bool drawDebug;
    }
}
