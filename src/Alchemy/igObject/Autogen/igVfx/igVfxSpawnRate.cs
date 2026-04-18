namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class igVfxSpawnRate : igVfxRuntimeObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVfxSpawnRateData? _source;
        [FieldAttr(nst: 24, ctr: 24)] public float _remainder;
        [FieldAttr(nst: 28, ctr: 28)] public igRandomMetaField _random = new();
    }
}
