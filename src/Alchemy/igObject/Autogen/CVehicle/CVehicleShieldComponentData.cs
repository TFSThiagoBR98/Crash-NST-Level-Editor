namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8)]
    public class CVehicleShieldComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igHandleMetaField _shieldsDamagedEffect = new();
        [FieldAttr(nst: 32)] public igHandleMetaField _shieldsRecoveredEffect = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _shieldsBrokenEffect = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _shieldsRestoredEffect = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _shieldsUpLoopEffect = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _shieldsLowLoopEffect = new();
        [FieldAttr(nst: 72)] public float _shieldsLowThreshold = 0.2f;
        [FieldAttr(nst: 80)] public igHandleMetaField _shieldsDownLoopEffect = new();
        [FieldAttr(nst: 88)] public CBoltPoint? _shieldEffectsBoltPoint;
        [FieldAttr(nst: 96)] public CDifficultySpecificFloat? _shieldPercentRegainedOnSkylanderDeath;
        [FieldAttr(nst: 104)] public bool _splitDamage;
    }
}
