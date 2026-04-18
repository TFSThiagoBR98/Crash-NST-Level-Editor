namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_CelebrateAbilityUpgradeComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_CelebrateAbilityUpgradeComponent_
    {
        [FieldAttr(nst: 40)] public float Delay = 0.5f;
        [FieldAttr(nst: 48)] public string? BehaviorEvent = "";
        [FieldAttr(nst: 56)] public string? CelebrationVO = "VO1_Champ_Banter_Upgrade";
        [FieldAttr(nst: 64)] public CVfxEffectDotNetHandle? Vfx;
        [FieldAttr(nst: 72)] public float ScaleBobs = 2.25f;
        [FieldAttr(nst: 76)] public float ScaleAmount = 1.5f;
        [FieldAttr(nst: 80)] public float ScaleDuration = 0.667f;
        [FieldAttr(nst: 84)] public float CelebrationDuration = 3.75f;
        [FieldAttr(nst: 88)] public float BroadcastRadius = 1000.0f;
    }
}
