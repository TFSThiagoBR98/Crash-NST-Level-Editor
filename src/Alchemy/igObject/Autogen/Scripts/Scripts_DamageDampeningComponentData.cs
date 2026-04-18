namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_DamageDampeningComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_DamageDampeningComponent_
    {
        [FieldAttr(nst: 40)] public float HighDampenDuration = 0.69999999f;
        [FieldAttr(nst: 44)] public float LowDampenDuration = 1.39999998f;
        [FieldAttr(nst: 48)] public float HighDampenMultiplier = 0.3f;
        [FieldAttr(nst: 52)] public float LowDampenMultiplier = 0.69999999f;
        [FieldAttr(nst: 56)] public int DamageThreshold = 10;
        [FieldAttr(nst: 60)] public float MaxPercentDamagePerHit = 0.25f;
        [FieldAttr(nst: 64)] public float MaxPercentDamagePerHitHard = 0.4f;
        [FieldAttr(nst: 68)] public float MaxPercentDamagePerHitNightmare = 0.5f;
        [FieldAttr(nst: 72)] public float NightmareGiantDamageMultiplier = 1.29999995f;
        [FieldAttr(nst: 76)] public float HardChompyDamageMultiplier = 1.39999998f;
        [FieldAttr(nst: 80)] public float NightmareChompyDamageMultiplier = 1.5f;
        [FieldAttr(nst: 84)] public int NightmareMinDamage = 217;
        [FieldAttr(nst: 88)] public float NightmareMinDamageMultiplier = 1.35f;
    }
}
