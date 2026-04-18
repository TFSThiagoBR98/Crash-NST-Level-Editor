namespace Alchemy
{
    [ObjectAttr(nst: 136, align: 8)]
    public class CVehicleBoostControllerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public int _loopingBoostVfxLayer = 2;
        [FieldAttr(nst: 28)] public int _startBoostVfxLayer = 3;
        [FieldAttr(nst: 32)] public float _startBoostVfxTime = 1.0f;
        [FieldAttr(nst: 36)] public float _boostDeltaFollowDistance = -320.0f;
        [FieldAttr(nst: 40)] public float _boostDeltaFollowHeight = -4.0f;
        [FieldAttr(nst: 44)] public float _boostDeltaFov = 38.0f;
        [FieldAttr(nst: 48)] public float _boostRatioDampingFactor = 0.2f;
        [FieldAttr(nst: 56)] public CLoopingVfxComponentData? _loopingVfxComponentData;
        [FieldAttr(nst: 64)] public CBoltPoint? _boostVfxBoltPoint;
        [FieldAttr(nst: 72)] public CBoltPoint? _boostVfxBoltPoint2;
        [FieldAttr(nst: 80)] public igHandleMetaField _linearBoostVfxToSpawn = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _linearPlayerBoostVfxToSpawn = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _arenaBoostVfxToSpawn = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _arenaPlayerBoostVfxToSpawn = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _expeditionBoostVfxToSpawn = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _expeditionPlayerBoostVfxToSpawn = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _boostRumbleData = new();
    }
}
