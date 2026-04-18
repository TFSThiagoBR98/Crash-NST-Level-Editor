namespace Alchemy
{
    [ObjectAttr(nst: 176, align: 8, metaType: typeof(Object))]
    public class Scripts_BoltOnData : Object
    {
        [FieldAttr(nst: 32)] public string? BoltOnModelString = null;
        [FieldAttr(nst: 40)] public CBoltPoint? BoltPoint;
        [FieldAttr(nst: 48)] public EBoltonModels BoltonModels = EBoltonModels.EBOLTON_NONE;
        [FieldAttr(nst: 52)] public bool NeedPreviousUpgrades;
        [FieldAttr(nst: 53)] public bool IsBoltOnUpgrade = true;
        [FieldAttr(nst: 56)] public string? BoltOnModelUpgradeString = null;
        [FieldAttr(nst: 64)] public igHandleMetaField SkillUpgade = new();
        [FieldAttr(nst: 72)] public bool IsBoltOnSecondUpgrade = true;
        [FieldAttr(nst: 80)] public string? BoltOnModelSecondUpgradeString = null;
        [FieldAttr(nst: 88)] public igHandleMetaField SkillSecondUpgade = new();
        [FieldAttr(nst: 96)] public bool IsBoltOnThirdUpgrade = true;
        [FieldAttr(nst: 104)] public string? BoltOnModelThirdUpgradeString = null;
        [FieldAttr(nst: 112)] public igHandleMetaField SkillThirdUpgrade = new();
        [FieldAttr(nst: 120)] public bool useGrouping;
        [FieldAttr(nst: 128)] public List_1? BoltOnGroupModelStrings;
        [FieldAttr(nst: 136)] public bool AddEmptySlotAutomatically = true;
        [FieldAttr(nst: 144)] public CEntityMessage? BoltMessage;
        [FieldAttr(nst: 152)] public CEntityMessage? UnboltMessage;
        [FieldAttr(nst: 160)] public CVfxEffectDotNetHandle? BoltVfx;
        [FieldAttr(nst: 168)] public bool HardKillVfx;
    }
}
