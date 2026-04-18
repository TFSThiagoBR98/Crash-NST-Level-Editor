namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 64, align: 8)]
    public class CCombatSoundData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public bool _playAttackSoundOnVictim = true;
        [FieldAttr(nst: 24, ctr: 16)] public string? _attackSound = null;
        [FieldAttr(nst: 32, ctr: 24)] public string? _victimSound = "COM_Impact_Victim_Basic";
        [FieldAttr(nst: 40, ctr: 32)] public igHandleMetaField _attackSoundHandle = new();
        [FieldAttr(nst: 48, ctr: 40)] public igHandleMetaField _victimSoundHandle = new();
        [FieldAttr(nst: 56, ctr: 48)] public CUpgradeableSound? _attackSoundUpgradeable;
        [FieldAttr(nst: 64, ctr: 56)] public CUpgradeableSound? _victimSoundUpgradeable;
    }
}
