namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 32, align: 8)]
    public class CAudioBinkSettings : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public string? _binkName = null;
        [FieldAttr(nst: 24, ctr: 24)] public float _volume = 1.0f;
    }
}
