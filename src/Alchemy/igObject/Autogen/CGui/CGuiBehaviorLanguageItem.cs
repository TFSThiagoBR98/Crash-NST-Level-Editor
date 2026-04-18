namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 56, align: 8)]
    public class CGuiBehaviorLanguageItem : igGuiBehavior
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igGuiPlaceable? _languageName;
        [FieldAttr(ctr: 24)] public string? _dialogTitle;
        [FieldAttr(ctr: 32)] public string? _dialogBody;
        [FieldAttr(nst: 24, ctr: 40)] public EIG_CORE_LANGUAGE _language;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _placeable;
    }
}
