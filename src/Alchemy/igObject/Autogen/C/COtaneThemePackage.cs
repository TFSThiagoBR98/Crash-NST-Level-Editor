namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class COtaneThemePackage : igObject
    {
        [FieldAttr(ctr: 16)] public igHandleMetaField _pickableEffect = new();
        [FieldAttr(ctr: 24)] public string? _pickableModel;
        [FieldAttr(ctr: 32)] public string? _pickableCrateModel;
        [FieldAttr(ctr: 40)] public string? _powerupCrateModel;
        [FieldAttr(ctr: 48)] public EDriverFaction _factionOverride;
        [FieldAttr(ctr: 56)] public COctaneThemeVFXEffectHashTable? _vfxSlots;
        [FieldAttr(ctr: 64)] public COctaneThemeSFXEffectHashTable? _sfxSlots;
    }
}
