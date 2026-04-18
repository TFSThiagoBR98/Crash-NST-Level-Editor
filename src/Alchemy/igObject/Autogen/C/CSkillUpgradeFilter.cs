namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class CSkillUpgradeFilter : CBaseUpgradeFilter
    {
        public enum ESkillUpgradeFilterType
        {
            eSUFT_UpgradeRequiredAsActive = 0,
            eSUFT_UpgradeRequiredAsInactive = 1,
        }

        [FieldAttr(nst: 16, ctr: 12)] public ESkillUpgradeFilterType _skillUpgradeFilterType;
        [FieldAttr(nst: 24, ctr: 16)] public igHandleMetaField _skillUpgrade = new();
    }
}
