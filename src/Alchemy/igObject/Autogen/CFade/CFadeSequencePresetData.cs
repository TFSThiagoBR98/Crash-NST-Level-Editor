namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 8)]
    public class CFadeSequencePresetData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _fadeOutDuration;
        [FieldAttr(nst: 24, ctr: 16)] public CAudioFadeData? _fadeOutAudioFadeData;
        [FieldAttr(nst: 32, ctr: 24)] public float _holdDuration;
        [FieldAttr(nst: 36, ctr: 28)] public float _fadeInDuration;
        [FieldAttr(nst: 40, ctr: 32)] public CAudioFadeData? _fadeInAudioFadeData;
        [FieldAttr(nst: 48, ctr: 40)] public Color? _color;
    }
}
