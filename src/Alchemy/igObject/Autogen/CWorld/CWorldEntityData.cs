namespace Alchemy
{
    [ObjectAttr(nst: 184, ctr: 216, align: 8)]
    public class CWorldEntityData : CEntityData
    {
        [FieldAttr(nst: 56, ctr: 56)] public uint _worldEntityFlags;
        [FieldAttr(nst: 60, ctr: 60)] public int _forceAct;
        [FieldAttr(nst: 64, ctr: 64)] public float _killz = -500.0f;
        [FieldAttr(nst: 68, ctr: 68)] public EWorldGameplayMode _startingGameplayMode;
        [FieldAttr(nst: 72, ctr: 72)] public float _airFriction;
        [FieldAttr(nst: 80, ctr: 80)] public igHandleMetaField _traversalStream = new();
        [FieldAttr(ctr: 88)] public igHandleMetaField _traversalLegacyStream = new();
        [FieldAttr(ctr: 96)] public igHandleMetaField _octaneBossFightStream = new();
        [FieldAttr(ctr: 104)] public bool _traversalPausedAtMapStart;
        [FieldAttr(nst: 88, ctr: 108)] public float _overrideTraversalTrack1Volume = -1.0f;
        [FieldAttr(nst: 92, ctr: 112)] public float _overrideTraversalAccelerationSmoothing = -1.0f;
        [FieldAttr(nst: 96, ctr: 116)] public float _overrideTraversalDecelerationSmoothing = -1.0f;
        [FieldAttr(nst: 100, ctr: 120)] public float _overrideTraversalZeroVolumeSpeed = -1.0f;
        [FieldAttr(nst: 104, ctr: 124)] public float _overrideTraversalFullVolumeSpeed = -1.0f;
        [FieldAttr(nst: 108, ctr: 128)] public float _overrideTraversalMaxSpeed = -1.0f;
        [FieldAttr(nst: 112, ctr: 136)] public igHandleMetaField _classicDspOverrideSet = new();
        [FieldAttr(nst: 120, ctr: 144)] public igHandleMetaField _vehicleDspOverrideSet = new();
        [FieldAttr(nst: 128, ctr: 152)] public igHandleMetaField _combatStream = new();
        [FieldAttr(ctr: 160)] public igHandleMetaField _octaneBossFightFinalLapStream = new();
        [FieldAttr(nst: 136, ctr: 168)] public CMusicMixList? _musicMixes;
        [FieldAttr(nst: 144, ctr: 176)] public igHandleMetaField _windGustSound = new();
        [FieldAttr(nst: 152, ctr: 184)] public string? _unpauseScript = null;
        [FieldAttr(nst: 160, ctr: 192)] public CNavMeshBuildDataList? _navmeshes;
        [FieldAttr(nst: 168, ctr: 200)] public igVec3fMetaField _startFadeColor = new();
        [FieldAttr(nst: 180, ctr: 212)] public bool _hasZeroGravity;
    }
}
