namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 88, align: 8)]
    public class CSkillUpgrade : CUpgrade
    {
        [FieldAttr(nst: 24, ctr: 24)] public string? _skillName = null;
        [FieldAttr(nst: 32, ctr: 32)] public int _cost;
        [FieldAttr(nst: 40, ctr: 40)] public string? _lockedUpgradeDescription = null;
        [FieldAttr(nst: 48, ctr: 48)] public CCharacterAttributeList? _upgradeAttributeBoost;
        [FieldAttr(nst: 56, ctr: 56)] public igHandleMetaField _prerequisiteUpgrade = new();
        [FieldAttr(nst: 64, ctr: 64)] public igHandleMetaField _previewImage = new();
        [FieldAttr(nst: 72, ctr: 72)] public bool _unlockInDemo;
        [FieldAttr(nst: 76, ctr: 76)] public EGameYear _year = EGameYear.eGY_Count;
        [FieldAttr(nst: 80, ctr: 80)] public int _toyAbilityFlagBit = -1;
    }
}
