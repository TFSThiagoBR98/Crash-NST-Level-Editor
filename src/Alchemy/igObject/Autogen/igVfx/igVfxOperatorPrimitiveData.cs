namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 120, align: 8)]
    public class igVfxOperatorPrimitiveData : igVfxPrimitiveData
    {
        [ObjectAttr(size: 4)]
        public class StackPrimitiveFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 2)] public ESortMode _sortMode;
            [FieldAttr(offset: 2, size: 1)] public bool _useSecondBolt;
            [FieldAttr(offset: 3, size: 1)] public bool _spawnByDistance;
            [FieldAttr(offset: 4, size: 7)] public int _totalStorageWords;
            [FieldAttr(offset: 11, size: 7)] public int _primitiveStorageWords;
            [FieldAttr(offset: 18, size: 5)] public int _procGeometryCount;
            [FieldAttr(offset: 23, size: 8)] public int _firstProcGeometryOperator;
            [FieldAttr(offset: 31, size: 1)] public bool _dirty;
        }

        [ObjectAttr(size: 2)]
        public class StackPrimitiveFlags2 : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _needsPreUpdate;
            [FieldAttr(offset: 1, size: 1)] public bool _needsPostUpdate;
            [FieldAttr(offset: 2, size: 1)] public bool _needsPauseResume;
            [FieldAttr(offset: 3, size: 1)] public bool _needsHasInstances;
            [FieldAttr(offset: 4, size: 1)] public bool _needsLateUpdate;
            [FieldAttr(offset: 5, size: 1)] public bool _supportsInstancePositionalData;
            [FieldAttr(offset: 6, size: 1)] public bool _needsActivateApply;
            [FieldAttr(offset: 7, size: 1)] public bool _needsDeactivateApply;
            [FieldAttr(offset: 8, size: 1)] public bool _needsGroundBolt;
        }

        [ObjectAttr(size: 2)]
        public class ZeroSpaceFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _track0ZeroSpace = EReferenceFrame.eRF_Bolt1;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _track1ZeroSpace = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 8, size: 4)] public EReferenceFrame _track2ZeroSpace = EReferenceFrame.eRF_World;
            [FieldAttr(offset: 12, size: 4)] public EReferenceFrame _track3ZeroSpace = EReferenceFrame.eRF_World;
        }

        [ObjectAttr(size: 4)]
        public class LocationSpaceFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _track0OrientationSpace;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _track1OrientationSpace;
            [FieldAttr(offset: 8, size: 4)] public EReferenceFrame _track2OrientationSpace;
            [FieldAttr(offset: 12, size: 4)] public EReferenceFrame _track3OrientationSpace;
            [FieldAttr(offset: 16, size: 4)] public EReferenceFrame _track0PositionSpace;
            [FieldAttr(offset: 20, size: 4)] public EReferenceFrame _track1PositionSpace;
            [FieldAttr(offset: 24, size: 4)] public EReferenceFrame _track2PositionSpace;
            [FieldAttr(offset: 28, size: 4)] public EReferenceFrame _track3PositionSpace;
        }

        [ObjectAttr(size: 4)]
        public class MotionSpaceFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 4)] public EReferenceFrame _track0SpinSpace;
            [FieldAttr(offset: 4, size: 4)] public EReferenceFrame _track1SpinSpace;
            [FieldAttr(offset: 8, size: 4)] public EReferenceFrame _track2SpinSpace;
            [FieldAttr(offset: 12, size: 4)] public EReferenceFrame _track3SpinSpace;
            [FieldAttr(offset: 16, size: 4)] public EReferenceFrame _track0VelocitySpace;
            [FieldAttr(offset: 20, size: 4)] public EReferenceFrame _track1VelocitySpace;
            [FieldAttr(offset: 24, size: 4)] public EReferenceFrame _track2VelocitySpace;
            [FieldAttr(offset: 28, size: 4)] public EReferenceFrame _track3VelocitySpace;
        }

        [FieldAttr(nst: 56, ctr: 64)] public StackPrimitiveFlags _stackPrimitiveFlags = new();
        [FieldAttr(nst: 60, ctr: 68)] public StackPrimitiveFlags2 _stackPrimitiveFlags2 = new();
        [FieldAttr(nst: 62, ctr: 70)] public ZeroSpaceFlags _zeroSpaceFlags = new();
        [FieldAttr(nst: 64, ctr: 72)] public LocationSpaceFlags _locationSpaceFlags = new();
        [FieldAttr(nst: 68, ctr: 76)] public MotionSpaceFlags _motionSpaceFlags = new();
        [FieldAttr(nst: 72, ctr: 80)] public u8[] _spawnZeroFlags = new u8[4];
        [FieldAttr(nst: 76, ctr: 84)] public u8[] _spawnStoreUpdateLoadFlags = new u8[4];
        [FieldAttr(nst: 80, ctr: 88)] public u8[] _updateZeroFlags = new u8[4];
        [FieldAttr(nst: 84, ctr: 92)] public u8[] _updateStoreFlags = new u8[4];
        [FieldAttr(nst: 88, ctr: 96)] public u8[] _combinedLivenessFlags = new u8[4];
        [FieldAttr(nst: 92, ctr: 100)] public u8[] _trackStorageOffsetWords = new u8[4];
        [FieldAttr(nst: 96, ctr: 104)] public igVfxStackOperatorList? _spawnStack;
        [FieldAttr(nst: 104, ctr: 112)] public igVfxStackOperatorList? _updateStack;
    }
}
