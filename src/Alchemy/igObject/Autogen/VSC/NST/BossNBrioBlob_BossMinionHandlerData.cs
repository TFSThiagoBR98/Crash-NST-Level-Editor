namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrioBlob_BossMinionHandlerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _OnContactDamageData = new();
        [FieldAttr(nst: 48)] public EigEaseType _OnTakeHitSpinExitFallEaseType;
        [FieldAttr(nst: 56)] public igHandleMetaField _DamageBossProjectileData = new();
        [FieldAttr(nst: 64)] public float _OnTakeHitSpinStopMomentumDelay;
        [FieldAttr(nst: 68)] public float _OnTakeHitSpinExitFallSpeed;
        [FieldAttr(nst: 72)] public float _OnTakeHitSpinExitFallEaseRatioIn;
        [FieldAttr(nst: 76)] public float _OnTakeHitSpinExitFallEaseRatioOut;
        [FieldAttr(nst: 80)] public float _CrashSpinPushAwayMaxHeight_0x50;
        [FieldAttr(nst: 84)] public float _RestTime;
        [FieldAttr(nst: 88)] public float _JumpToPlayerInitialDelay;
        [FieldAttr(nst: 92)] public float _JumpToPlayerHeight;
        [FieldAttr(nst: 96)] public float _JumpToPlayerTime;
        [FieldAttr(nst: 100)] public float _JumpToPlayerDelay;
        [FieldAttr(nst: 104)] public float _JumpTurnTime_0x68;
        [FieldAttr(nst: 108)] public float _CrashSpinPushAwayForce;
        [FieldAttr(nst: 112)] public int _JumpToPlayerCount;
        [FieldAttr(nst: 116)] public float _JumpTurnTime_0x74;
        [FieldAttr(nst: 120)] public float _CrashSpinPushAwayMaxHeight_0x78;
        [FieldAttr(nst: 124)] public float _Float;
    }
}
