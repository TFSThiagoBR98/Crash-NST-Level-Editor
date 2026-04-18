namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 48, align: 8)]
    public class CutsceneActionPlayVO : CCutsceneAction
    {
        [FieldAttr(nst: 24, ctr: 24)] public string? _wavFile = null;
        [FieldAttr(nst: 32, ctr: 32)] public string? _subtitleString = null;
        [FieldAttr(ctr: 40)] public bool _forced;
        [FieldAttr(ctr: 41)] public bool _skipInEnglish;
    }
}
