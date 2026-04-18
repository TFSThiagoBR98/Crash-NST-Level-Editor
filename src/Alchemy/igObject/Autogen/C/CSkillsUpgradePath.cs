namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CSkillsUpgradePath : igNamedObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public string? _description = "[Description Missing]";
        [FieldAttr(nst: 32, ctr: 32)] public CSkillUpgradeList? _skills;
    }
}
