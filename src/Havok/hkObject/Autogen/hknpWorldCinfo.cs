using Alchemy;
using System.Numerics;

namespace Havok
{
    [ObjectAttr(nst: 256, ctr: 256)]
    public class hknpWorldCinfo : hkObject
    {
        public override uint Hash => 0x6300cf42;

        [FieldAttr(nst: 0, ctr: 0)] public int _bodyBufferCapacity;
        [FieldAttr(nst: 8, ctr: 8)] public uint _userBodyBuffer;
        [FieldAttr(nst: 16, ctr: 16)] public int _motionBufferCapacity;
        [FieldAttr(nst: 24, ctr: 24)] public uint _userMotionBuffer;
        [FieldAttr(nst: 32, ctr: 32)] public int _constraintBufferCapacity;
        [FieldAttr(nst: 40, ctr: 40)] public uint _userConstraintBuffer;
        [FieldAttr(nst: 48, ctr: 48)] public uint _persistentStreamAllocator;
        [FieldAttr(nst: 56, ctr: 56)] public hknpMaterialLibrary? _materialLibrary;
        [FieldAttr(nst: 64, ctr: 64)] public hknpMotionPropertiesLibrary? _motionPropertiesLibrary;
        [FieldAttr(nst: 72, ctr: 72)] public hknpBodyQualityLibrary? _qualityLibrary;
        [FieldAttr(nst: 80, ctr: 80)] public ESimulationType _simulationType;
        [FieldAttr(nst: 84, ctr: 84)] public int _numSplitterCells;
        [FieldAttr(nst: 96, ctr: 96)] public Vector4 _gravity;
        [FieldAttr(nst: 112, ctr: 112)] public bool _enableContactCaching;
        [FieldAttr(nst: 113, ctr: 113)] public bool _mergeEventsBeforeDispatch;
        [FieldAttr(nst: 114, ctr: 114)] public ELeavingBroadPhaseBehavior _leavingBroadPhaseBehavior;
        [FieldAttr(nst: 128, ctr: 128)] public Vector4 _min;
        [FieldAttr(nst: 144, ctr: 144)] public Vector4 _max;
        [FieldAttr(nst: 160, ctr: 160)] public hknpBroadPhaseConfig? _broadPhaseConfig;
        [FieldAttr(nst: 168, ctr: 168)] public hknpCollisionFilter? _collisionFilter;
        [FieldAttr(nst: 176, ctr: 176)] public hknpShapeTagCodec? _shapeTagCodec;
        [FieldAttr(nst: 184, ctr: 184)] public float _collisionTolerance;
        [FieldAttr(nst: 188, ctr: 188)] public float _relativeCollisionAccuracy;
        [FieldAttr(nst: 192, ctr: 192)] public bool _enableWeldingForDefaultObjects;
        [FieldAttr(nst: 193, ctr: 193)] public bool _enableWeldingForCriticalObjects;
        [FieldAttr(nst: 196, ctr: 196)] public float _solverTau;
        [FieldAttr(nst: 200, ctr: 200)] public float _solverDamp;
        [FieldAttr(nst: 204, ctr: 204)] public int _solverIterations;
        [FieldAttr(nst: 208, ctr: 208)] public int _solverMicrosteps;
        [FieldAttr(nst: 212, ctr: 212)] public float _defaultSolverTimestep;
        [FieldAttr(nst: 216, ctr: 216)] public float _maxApproachSpeedForHighQualitySolver;
        [FieldAttr(nst: 220, ctr: 220)] public bool _enableDeactivation;
        [FieldAttr(nst: 221, ctr: 221)] public bool _deleteCachesOnDeactivation;
        [FieldAttr(nst: 224, ctr: 224)] public int _largeIslandSize;
        [FieldAttr(nst: 228, ctr: 228)] public bool _enableSolverDynamicScheduling;
        [FieldAttr(nst: 232, ctr: 232)] public EEnum _contactSolverType;
        [FieldAttr(nst: 236, ctr: 236)] public float _unitScale;
        [FieldAttr(nst: 240, ctr: 240)] public bool _applyUnitScaleToStaticConstants;
    }
}