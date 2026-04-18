namespace Alchemy
{
    [ObjectAttr(ctr: 24, align: 8)]
    public class igVscAbsIntAccessor : igVscIntAccessor
    {
        [FieldAttr(ctr: 16)] public igVscIntAccessor? _input;
    }
}
