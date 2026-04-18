namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CFadeOutPresetData : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public float _duration;
        [FieldAttr(nst: 24, ctr: 16)] public Color? _color;
        [FieldAttr(nst: 32, ctr: 24)] public CAudioFadeData? _audioFadeData;
    }
}
