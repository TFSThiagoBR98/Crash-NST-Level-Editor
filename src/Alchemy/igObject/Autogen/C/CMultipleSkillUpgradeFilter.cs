namespace Alchemy
{
    [ObjectAttr(nst: 24, align: 8)]
    public class CMultipleSkillUpgradeFilter : CBaseUpgradeFilter
    {
        [FieldAttr(nst: 16)] public CSkillUpgradeFilterList? _skillUpgradeFilters;
    }
}
