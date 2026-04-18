namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 8, metaType: typeof(CDotNetEntityComponentData_1))]
    public class Scripts_UpgradeRequiredComponentData : NovaScript_CDotNetEntityComponentData_1_Scripts_UpgradeRequiredComponent_
    {
        [FieldAttr(nst: 40)] public CBaseUpgradeFilter? SkillUpgradeList;
        [FieldAttr(nst: 48)] public bool UseCreator;
        [FieldAttr(nst: 56)] public CEntityComponentData? ComponentToAttach;
        [FieldAttr(nst: 64)] public bool AttachToDummy = true;
    }
}
