namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class igVscStringMacroAccessor : igVscStringAccessor
    {
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public igObject? _accessorMetaField;
        [FieldAttr(nst: 32, ctr: 24)] public string? _default = null;
    }
}
