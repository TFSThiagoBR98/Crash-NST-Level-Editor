namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 160, align: 8)]
    public class CVehicleAudioComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public CAudioGraphDriverList? _driverList;
        [FieldAttr(nst: 32, ctr: 24)] public CAudioGraphDriverList? _nonLocalPlayerDriverList;
        [FieldAttr(nst: 40, ctr: 32)] public CVehicleAudioCollisionDataList? _collisionDataList;
        [FieldAttr(nst: 48)] public CModSoundDataList? _modSoundDataList;
        [FieldAttr(ctr: 40)] public bool _isUsingSurfaceSoundFiltering;
        [FieldAttr(nst: 56, ctr: 48)] public igHandleMetaField _soundOnOneShot = new();
        [FieldAttr(nst: 64, ctr: 56)] public igHandleMetaField _soundOffOneShot = new();
        [FieldAttr(nst: 72, ctr: 64)] public igHandleMetaField _onGroundLoopingSound = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _onWaterLoopingSound = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _submergedLoopingSound = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _onWaterNonLocalPlayerLoopingSound = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _submergedNonLocalPlayerLoopingSound = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _nonLocalOnGroundLoopingSound = new();
        [FieldAttr(ctr: 80)] public igHandleMetaField _localDriftFailOneShot = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _nonLocalDriftFailOneShot = new();
        [FieldAttr(nst: 112, ctr: 96)] public bool _useRacingUpdateFrequency = true;
        [FieldAttr(ctr: 104)] public igHandleMetaField _localInHornSound = new();
        [FieldAttr(ctr: 112)] public igHandleMetaField _nonLocalInHornSound = new();
        [FieldAttr(ctr: 120)] public igHandleMetaField _localLoopHornSound = new();
        [FieldAttr(ctr: 128)] public igHandleMetaField _nonLocalLoopHornSound = new();
        [FieldAttr(ctr: 136)] public igHandleMetaField _localOutHornSound = new();
        [FieldAttr(ctr: 144)] public igHandleMetaField _nonLocalOutHornSound = new();
        [FieldAttr(ctr: 152)] public float _maxHornTime;
        [FieldAttr(nst: 113, ctr: 156)] public bool _alwaysUpdateAudio = true;
    }
}
