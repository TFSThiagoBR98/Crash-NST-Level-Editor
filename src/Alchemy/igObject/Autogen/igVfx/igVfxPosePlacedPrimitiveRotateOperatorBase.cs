namespace Alchemy
{
    [ObjectAttr(nst: 104, ctr: 88, align: 8)]
    public class igVfxPosePlacedPrimitiveRotateOperatorBase : igVfxLoadOperator
    {
        [ObjectAttr(size: 4)]
        public class PlacedPrimitiveFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _isLockedToGroundBolt;
            [FieldAttr(offset: 1, size: 1)] public bool _isLockedToBolt;
            [FieldAttr(offset: 2, size: 1)] public bool _isBillboard;
            [FieldAttr(offset: 3, size: 1)] public bool _hackRotationFix;
            [FieldAttr(offset: 4, size: 1)] public bool _isBillboardViewPlaneAligned = false;
            [FieldAttr(offset: 5, size: 1)] public bool _isBillboardAxisAligned;
            [FieldAttr(offset: 6, size: 1)] public bool _isOrientationRandom;
            [FieldAttr(offset: 7, size: 2)] public ETransformSpace _orientationSpace = ETransformSpace.kCameraSpace;
            [FieldAttr(offset: 9, size: 1)] public bool _isRotationAxisRandom;
            [FieldAttr(offset: 10, size: 1)] public bool _isRotationAppliedToOrientation = false;
            [FieldAttr(offset: 11, size: 2)] public ETransformSpace _rotationSpace = ETransformSpace.kCameraSpace;
            [FieldAttr(offset: 13, size: 1)] public bool _useMotionPathDuration;
            [FieldAttr(offset: 14, size: 3)] public EMotionPathBehavior _motionPathBehavior = EMotionPathBehavior.kSpawnAlongPath;
        }

        [FieldAttr(nst: 32, ctr: 20)] public PlacedPrimitiveFlags _placedPrimitiveFlags = new();
        [FieldAttr(nst: 36, ctr: 24)] public igVec3fMetaField _orientationInfo = new();
        [FieldAttr(nst: 48, ctr: 36)] public igVec3fMetaField _rotationAxisInternal = new();
        [FieldAttr(nst: 60, ctr: 48)] public float _fixedRotationAngle;
        [FieldAttr(nst: 64, ctr: 52)] public float _fixedRotationRadius;
        [FieldAttr(nst: 72, ctr: 56)] public string? _motionModelName = null;
        [FieldAttr(nst: 80, ctr: 64)] public string? _motionPathName = "MotionPath";
        [FieldAttr(nst: 88, ctr: 72)] public igTransform? _motionPath;
        [FieldAttr(nst: 96, ctr: 80)] public EReferenceFrame _spawnLocationTrack = EReferenceFrame.eRF_Track2;
    }
}
