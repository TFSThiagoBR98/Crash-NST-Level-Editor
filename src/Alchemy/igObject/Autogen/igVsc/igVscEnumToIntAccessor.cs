namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscEnumToIntAccessor : igVscIntAccessor
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVscEnumAccessor? _accessor;
    }
}
