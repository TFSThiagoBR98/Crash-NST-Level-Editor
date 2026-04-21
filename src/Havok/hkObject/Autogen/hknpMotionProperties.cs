using Alchemy;

namespace Havok
{
    [ObjectAttr(nst: 64, ctr: 64)]
    public class hknpMotionProperties : hkObject
    {
        public override uint Hash => 0x5dee8641;

        [FieldAttr(nst: 0, ctr: 0)] public bool _isExclusive;
        [FieldAttr(nst: 4, ctr: 4)] public uint _flags;
        [FieldAttr(nst: 8, ctr: 8)] public float _gravityFactor;
        [FieldAttr(nst: 12, ctr: 12)] public float _timeFactor;
        [FieldAttr(nst: 16, ctr: 16)] public float _maxLinearSpeed;
        [FieldAttr(nst: 20, ctr: 20)] public float _maxAngularSpeed;
        [FieldAttr(nst: 24, ctr: 24)] public float _linearDamping;
        [FieldAttr(nst: 28, ctr: 28)] public float _angularDamping;
        [FieldAttr(nst: 32, ctr: 32)] public float _solverStabilizationSpeedThreshold;
        [FieldAttr(nst: 36, ctr: 36)] public float _solverStabilizationSpeedReduction;
        [FieldAttr(nst: 40, ctr: 40)] public float _maxDistSqrd;
        [FieldAttr(nst: 44, ctr: 44)] public float _maxRotSqrd;
        [FieldAttr(nst: 48, ctr: 48)] public float _invBlockSize;
        [FieldAttr(nst: 52, ctr: 52)] public i16 _pathingUpperThreshold;
        [FieldAttr(nst: 54, ctr: 54)] public i16 _pathingLowerThreshold;
        [FieldAttr(nst: 56, ctr: 56)] public u8 _numDeactivationFrequencyPasses;
        [FieldAttr(nst: 57, ctr: 57)] public u8 _deactivationVelocityScaleSquare;
        [FieldAttr(nst: 58, ctr: 58)] public u8 _minimumPathingVelocityScaleSquare;
        [FieldAttr(nst: 59, ctr: 59)] public u8 _spikingVelocityScaleThresholdSquared;
        [FieldAttr(nst: 60, ctr: 60)] public u8 _minimumSpikingVelocityScaleSquared;
    }
}