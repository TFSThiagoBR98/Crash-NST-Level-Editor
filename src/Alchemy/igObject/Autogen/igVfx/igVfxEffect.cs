namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igVfxEffect : igVfxPrimitiveDataList
    {
        public enum EInvalidBoltBehavior
        {
            kSoftKill = 0,
            kHardKill = 1,
            kContinue = 2,
        }

        public enum ECameraVisibility
        {
            kAllCameras = 0,
            kPlayerSpecific = 1,
        }

        public enum EPriorityClass
        {
            kLowPriority = 0,
            kMediumPriority = 1,
            kHighPriority = 2,
        }

        [ObjectAttr(size: 4)]
        public class EffectFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 2)] public igVfxEffect.EInvalidBoltBehavior _invalidBoltBehavior;
            [FieldAttr(offset: 2, size: 1)] public bool _playOutLoopOnSoftKill;
            [FieldAttr(offset: 3, size: 1)] public bool _keepBoltScale;
            [FieldAttr(offset: 4, size: 1)] public bool _keepBoltVisibility;
            [FieldAttr(offset: 5, size: 1)] public bool _softCull;
            [FieldAttr(offset: 6, size: 1)] public bool _pauseAfterSoftCull;
            [FieldAttr(offset: 7, size: 2)] public igVfxEffect.ECameraVisibility _cameraVisibility;
            [FieldAttr(offset: 9, size: 1)] public bool _forceLateUpdate;
            [FieldAttr(offset: 10, size: 1)] public bool _useLevelCameraCullDistance;
            [FieldAttr(offset: 11, size: 2)] public igVfxEffect.EPriorityClass _priority;
        }

        [FieldAttr(nst: 40, ctr: 40)] public igTimeMetaField _loopStart = new();
        [FieldAttr(nst: 44, ctr: 44)] public igTimeMetaField _loopEnd = new();
        [FieldAttr(nst: 48, ctr: 48)] public EffectFlags _effectFlags = new();
        [FieldAttr(nst: 52, ctr: 52)] public float _cameraCullDistance = -1.0f;
        [FieldAttr(nst: 56, ctr: 56)] public float _effectViewBounds = 1000.0f;
        [FieldAttr(nst: 60, ctr: 60)] public float _hardCullPauseDelay;
        [FieldAttr(nst: 64, ctr: 64)] public float _windupTime;
        [FieldAttr(nst: 68, ctr: 68)] public float _windupTick;
        [FieldAttr(nst: 72, ctr: 72)] public igVfxManager.ESpawnGroup _spawnGroup;
        [FieldAttr(nst: 76, ctr: 76)] public uint _seed;
    }
}
