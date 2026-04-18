namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 8)]
    public class CLoopingVfxComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public bool _vfxEnabledOnStart = true;
        [FieldAttr(nst: 25, ctr: 17)] public bool _requireSpecificVfxOnMessage;
        [FieldAttr(nst: 26, ctr: 18)] public bool _hideVfxWhenEntityInvisible;
        [FieldAttr(nst: 27, ctr: 19)] public bool _inhibitLooping;
        [FieldAttr(nst: 28, ctr: 20)] public bool _respawnOnTeleport;
        [FieldAttr(nst: 32, ctr: 24)] public igHandleMetaField _effect = new();
        [FieldAttr(nst: 40, ctr: 32)] public igVfxManager.EffectKillType _effectKillType = igVfxManager.EffectKillType.kHardKill;
        [FieldAttr(nst: 48, ctr: 40)] public CBoltPoint? _boltPoint;
        [FieldAttr(nst: 56, ctr: 48)] public CBoltPoint? _boltPoint2;
        [FieldAttr(nst: 64, ctr: 56)] public igHandleMetaField _boltEntity2 = new();
        [FieldAttr(nst: 72)] public CBaseVehicleModeFilter? _vehicleModeFilter;
    }
}
