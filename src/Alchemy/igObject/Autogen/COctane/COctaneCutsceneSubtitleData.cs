namespace Alchemy
{
    [ObjectAttr(ctr: 48, align: 8)]
    public class COctaneCutsceneSubtitleData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _characterName;
        [FieldAttr(ctr: 24)] public string? _subtitleLine;
        [FieldAttr(ctr: 32)] public float _interpolationTime;
        [FieldAttr(ctr: 36)] public float _fadeOutTime;
        [FieldAttr(ctr: 40)] public bool _forced;
        [FieldAttr(ctr: 41)] public bool _skipInEnglish;
    }
}
