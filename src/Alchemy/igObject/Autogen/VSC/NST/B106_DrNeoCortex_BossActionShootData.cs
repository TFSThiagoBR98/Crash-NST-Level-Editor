namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class B106_DrNeoCortex_BossActionShootData : CVscComponentData
    {
        public enum EReloadAction
        {
            NoReload = 0,
            Reload = 1,
            ReloadLong = 2,
        }

        public enum EProjectileType
        {
            Purple = 0,
            Green = 1,
            Blue = 2,
        }

        [FieldAttr(nst: 40)] public bool _IsReturnProjectileSuperStage;
        [FieldAttr(nst: 48)] public igHandleMetaField _ProjectileData = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _BlueHazardMoverTemplate = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _TargetingEntity = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _ReturnProjectileStageTemplate = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _ReturnProjectileStageTarget = new();
        [FieldAttr(nst: 88)] public EReloadAction _ReloadAction;
        [FieldAttr(nst: 92)] public EProjectileType _ProjectileType;
        [FieldAttr(nst: 96)] public float _DelayActionStart;
        [FieldAttr(nst: 104)] public igHandleMetaField _ProjectileSpawnData = new();
        [FieldAttr(nst: 112)] public bool _Bool;
    }
}
