using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 80, ctr: 80)]
    public class hknpMaterial : hkObject
    {
        public override uint Hash => 0xb7c5f24e;

        [FieldAttr(nst: 0, ctr: 0)] public string? _name;
        [FieldAttr(nst: 8, ctr: 8)] public bool _isExclusive;
        [FieldAttr(nst: 12, ctr: 12)] public int _flags;
        [FieldAttr(nst: 16, ctr: 16)] public ETriggerType _triggerType;
        [FieldAttr(nst: 17, ctr: 17)] public u8 _triggerManifoldTolerance;
        [FieldAttr(nst: 18, ctr: 18)] public Half _dynamicFriction;
        [FieldAttr(nst: 20, ctr: 20)] public Half _staticFriction;
        [FieldAttr(nst: 22, ctr: 22)] public Half _restitution;
        [FieldAttr(nst: 24, ctr: 24)] public ECombinePolicy _frictionCombinePolicy;
        [FieldAttr(nst: 25, ctr: 25)] public ECombinePolicy _restitutionCombinePolicy;
        [FieldAttr(nst: 26, ctr: 26)] public Half _weldingTolerance;
        [FieldAttr(nst: 28, ctr: 28)] public float _maxContactImpulse;
        [FieldAttr(nst: 32, ctr: 32)] public float _fractionOfClippedImpulseToApply;
        [FieldAttr(nst: 36, ctr: 36)] public EMassChangerCategory _massChangerCategory;
        [FieldAttr(nst: 38, ctr: 38)] public Half _massChangerHeavyObjectFactor;
        [FieldAttr(nst: 40, ctr: 40)] public Half _softContactForceFactor;
        [FieldAttr(nst: 42, ctr: 42)] public Half _softContactDampFactor;
        [FieldAttr(nst: 44, ctr: 44)] public u8 _softContactSeperationVelocity;
        [FieldAttr(nst: 48, ctr: 48)] public hknpSurfaceVelocity? _surfaceVelocity;
        [FieldAttr(nst: 56, ctr: 56)] public Half _disablingCollisionsBetweenCvxCvxDynamicObjectsDistance;
        [FieldAttr(nst: 64, ctr: 64)] public u64 _userData;
        [FieldAttr(nst: 72, ctr: 72)] public bool _isShared;
    }
}