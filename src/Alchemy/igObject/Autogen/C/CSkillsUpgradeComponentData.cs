namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 40, align: 8)]
    public class CSkillsUpgradeComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public CSkillUpgradeList? _initialAbilities;
        [FieldAttr(nst: 32, ctr: 24)] public CSkillsUpgradePathList? _upgrades;
        [FieldAttr(nst: 40, ctr: 32)] public int _debugOptionalUpgradePath;
        [FieldAttr(nst: 44, ctr: 36)] public bool _ignorePlayerChecks;
    }
}
