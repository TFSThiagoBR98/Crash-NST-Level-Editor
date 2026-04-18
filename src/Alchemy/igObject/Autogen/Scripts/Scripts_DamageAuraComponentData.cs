namespace Alchemy
{
    [ObjectAttr(nst: 232, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_DamageAuraComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_DamageAuraComponent_
    {
        [FieldAttr(nst: 40)] public CVfxEffectDotNetHandle? AuraFx;
        [FieldAttr(nst: 48)] public CBoltPoint? BoltPoint;
        [FieldAttr(nst: 56)] public bool HardKillOnDisable;
        [FieldAttr(nst: 64)] public string? ComponentIdentifier = null;
        [FieldAttr(nst: 72)] public bool AllowSameComponentStacking = true;
        [FieldAttr(nst: 80)] public CDamageData? DamageData;
        [FieldAttr(nst: 88)] public CDamageData? DamageDataPVP;
        [FieldAttr(nst: 96)] public float Life = 3.0f;
        [FieldAttr(nst: 100)] public bool RemoveOnLifeEnd = true;
        [FieldAttr(nst: 101)] public bool RemoveOnVisibilityChange;
        [FieldAttr(nst: 104)] public float XHitOffset = 100.0f;
        [FieldAttr(nst: 108)] public float ZHitOffset = 50.0f;
        [FieldAttr(nst: 112)] public float HitCount;
        [FieldAttr(nst: 116)] public bool RemoveOnLastHit;
        [FieldAttr(nst: 117)] public bool UseHitBased;
        [FieldAttr(nst: 120)] public float HitCooldown = 1.0f;
        [FieldAttr(nst: 128)] public CPhysicalEntityData? HitBaseEntity;
        [FieldAttr(nst: 136)] public CTriggerVolumeSphereComponentData? HitTriggerVolumeData;
        [FieldAttr(nst: 144)] public float TurnSpeed;
        [FieldAttr(nst: 148)] public bool TurnRight;
        [FieldAttr(nst: 152)] public CVfxEffectDotNetHandle? PerHitVfx;
        [FieldAttr(nst: 160)] public CBoltPoint? HitVfxBolt;
        [FieldAttr(nst: 168)] public CQueryFilter? QueryData;
        [FieldAttr(nst: 176)] public float Interval = 0.2f;
        [FieldAttr(nst: 180)] public bool UseInterval = true;
        [FieldAttr(nst: 184)] public CVfxEffectDotNetHandle? IntervalAttackVfx;
        [FieldAttr(nst: 192)] public CUpgradeableVfx? IntervalAttackVfxUpgradeable;
        [FieldAttr(nst: 200)] public CBoltPoint? IntervalAttackVfxBoltPoint;
        [FieldAttr(nst: 208)] public bool IntervalUseTwoBoltVfx;
        [FieldAttr(nst: 216)] public CBoltPoint? IntervalAttackVoltVfxBoltPoint01;
        [FieldAttr(nst: 224)] public CBoltPoint? IntervalAttackVoltVfxBoltPoint02;
    }
}
