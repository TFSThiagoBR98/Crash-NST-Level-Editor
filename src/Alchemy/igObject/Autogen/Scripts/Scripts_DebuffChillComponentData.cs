namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_DebuffChillComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_DebuffChillComponent_
    {
        [FieldAttr(nst: 40)] public CVfxEffectDotNetHandle? ChillFX;
        [FieldAttr(nst: 48)] public CUpgradeableVfx? UpgradeableChillFX;
        [FieldAttr(nst: 56)] public bool HardKillEffect = true;
        [FieldAttr(nst: 64)] public CBoltPoint? EffectBoltPoint;
        [FieldAttr(nst: 72)] public float ChillDuration = 1.5f;
        [FieldAttr(nst: 76)] public float ChillDurationBeforeEasing = 0.75f;
        [FieldAttr(nst: 80)] public float ChillIntensity = 0.5f;
        [FieldAttr(nst: 88)] public CDamageData? IntervalDamage;
        [FieldAttr(nst: 96)] public float IntervalDuration = 0.5f;
        [FieldAttr(nst: 100)] public bool SlowSpawnedProjectiles;
    }
}
