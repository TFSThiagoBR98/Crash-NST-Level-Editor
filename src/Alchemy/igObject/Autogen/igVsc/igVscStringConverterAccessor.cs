namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscStringConverterAccessor : igVscStringAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVscAccessor? _accessor;
    }
}
