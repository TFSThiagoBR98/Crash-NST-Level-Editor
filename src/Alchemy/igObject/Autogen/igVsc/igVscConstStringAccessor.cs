namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscConstStringAccessor : igVscStringAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public string? _value = null;
    }
}
