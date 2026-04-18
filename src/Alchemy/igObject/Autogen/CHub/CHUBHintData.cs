namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CHUBHintData : igObject
    {
        [FieldAttr(ctr: 16)] public string? _hintText;
        [FieldAttr(ctr: 24)] public string? _hintName;
        [FieldAttr(ctr: 32)] public string? _hintSoundName;
        [FieldAttr(ctr: 40)] public igHandleMetaField _hintModelRig = new();
        [FieldAttr(ctr: 48)] public string? _hintModelAnimIntro;
        [FieldAttr(ctr: 56)] public string? _hintModelAnimHint;
        [FieldAttr(ctr: 64)] public CHubHintTeamData? _akuAkuData;
        [FieldAttr(ctr: 72)] public CHubHintTeamData? _ukaUkaData;
    }
}
