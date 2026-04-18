namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 4)]
    public class CDebugSystemData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public int _basicAbility1UnlockLevel = 2;
        [FieldAttr(nst: 20, ctr: 16)] public int _basicAbility2UnlockLevel = 4;
        [FieldAttr(nst: 24, ctr: 20)] public int _basicAbility3UnlockLevel = 6;
        [FieldAttr(nst: 28, ctr: 24)] public int _basicAbility4UnlockLevel = 8;
        [FieldAttr(nst: 32, ctr: 28)] public int _optionalAbility1UnlockLevel = 10;
        [FieldAttr(nst: 36, ctr: 32)] public int _optionalAbility2UnlockLevel = 12;
        [FieldAttr(nst: 40, ctr: 36)] public int _optionalAbility3UnlockLevel = 14;
        [FieldAttr(nst: 44, ctr: 40)] public int _soulGemAbilityUnlockLevel = 16;
        [FieldAttr(nst: 48, ctr: 44)] public int _wowPowAbilityUnlockLevel = 18;
    }
}
