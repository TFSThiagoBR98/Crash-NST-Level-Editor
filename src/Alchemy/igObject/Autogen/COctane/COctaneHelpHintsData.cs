namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class COctaneHelpHintsData : igObject
    {
        [FieldAttr(ctr: 12)] public EOctaneAdventureHints _hintFlag;
        [FieldAttr(ctr: 16)] public string? _hintMovieName;
        [FieldAttr(ctr: 24)] public igHandleMetaField _hintImage = new();
        [FieldAttr(ctr: 32)] public string? _hintText;
        [FieldAttr(ctr: 40)] public string? _hintName;
        [FieldAttr(ctr: 48)] public string? _hintVoiceOverName;
    }
}
