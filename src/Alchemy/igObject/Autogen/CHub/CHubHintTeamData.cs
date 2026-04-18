namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CHubHintTeamData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _voodooMaskAnimIntro;
        [FieldAttr(ctr: 24)] public string? _voodooMaskAnimHint;
        [FieldAttr(ctr: 32)] public CEdcInfo? _voodooMaskEdcInfo;
    }
}
