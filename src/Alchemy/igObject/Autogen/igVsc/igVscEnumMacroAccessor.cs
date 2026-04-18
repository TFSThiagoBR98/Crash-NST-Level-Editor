namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class igVscEnumMacroAccessor : igVscEnumAccessor
    {
        [FieldAttr(nst: 24, refCount: false)] public igObject? _accessorMetaField;
        [FieldAttr(nst: 32)] public int _default;
    }
}
