namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class igEffectAnnotation : igObject
    {
        [FieldAttr(nst: 16)] public string? _name = null;
        [FieldAttr(nst: 24)] public string? _value = null;
    }
}
