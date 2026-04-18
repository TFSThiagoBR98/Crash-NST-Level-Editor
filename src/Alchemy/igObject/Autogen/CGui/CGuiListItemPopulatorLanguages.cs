namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 136, align: 8)]
    public class CGuiListItemPopulatorLanguages : igGuiListItemPopulator
    {
        [FieldAttr(nst: 16, ctr: 16)] public igLanguageList? _languages;
        [FieldAttr(nst: 24, ctr: 24)] public string? _english = null;
        [FieldAttr(nst: 32, ctr: 32)] public string? _french = null;
        [FieldAttr(nst: 40, ctr: 40)] public string? _italian = null;
        [FieldAttr(nst: 48, ctr: 48)] public string? _german = null;
        [FieldAttr(nst: 56, ctr: 56)] public string? _spanish = null;
        [FieldAttr(nst: 64, ctr: 64)] public string? _dutch = null;
        [FieldAttr(nst: 72, ctr: 72)] public string? _danish = null;
        [FieldAttr(nst: 80, ctr: 80)] public string? _swedish = null;
        [FieldAttr(nst: 88, ctr: 88)] public string? _finnish = null;
        [FieldAttr(nst: 96, ctr: 96)] public string? _norwegian = null;
        [FieldAttr(nst: 104, ctr: 104)] public string? _japanese = null;
        [FieldAttr(ctr: 112)] public string? _portuguese;
        [FieldAttr(ctr: 120)] public string? _mexican_spanish;
        [FieldAttr(ctr: 128)] public string? _arabic;
    }
}
