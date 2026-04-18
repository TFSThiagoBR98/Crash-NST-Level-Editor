namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 8)]
    public class COpenKeyboardParams : igObject
    {
        [FieldAttr(nst: 16)] public EPlayerId _playerId;
        [FieldAttr(nst: 20)] public uint _maxTextLength;
        [FieldAttr(nst: 24)] public igVec2fMetaField _position = new();
        [FieldAttr(nst: 32)] public string? _placeholderText = null;
        [FieldAttr(nst: 40)] public string? _titleText = null;
        [FieldAttr(nst: 48)] public igLanguageList? _allowedLanguages;
    }
}
