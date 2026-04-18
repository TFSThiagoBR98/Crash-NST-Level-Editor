namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class CAudioArchive : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _name = "NOT_SET";
        [FieldAttr(nst: 24, ctr: 24)] public CSoundList? _soundList;
        [FieldAttr(nst: 32, ctr: 32)] public CPlatformAudioSettingsOverrideList? _settingsOverrideList;
        [FieldAttr(nst: 40, ctr: 40)] public bool _isStreamed;
        [FieldAttr(nst: 41, ctr: 41)] public bool _isGenerated;
        [FieldAttr(nst: 42, ctr: 42)] public bool _isLocalized;
        [FieldAttr(nst: 43, ctr: 43)] public bool _default;
        [FieldAttr(nst: 44, ctr: 44)] public bool _isCollisionBank;
        [FieldAttr(nst: 45, ctr: 45)] public bool _loaded;
        [FieldAttr(nst: 46, ctr: 46)] public bool _sorted;
        [FieldAttr(nst: 47, ctr: 47)] public bool _mute;
        [FieldAttr(nst: 48, ctr: 48)] public bool _solo;
    }
}
