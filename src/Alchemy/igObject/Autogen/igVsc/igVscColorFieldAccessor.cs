namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class igVscColorFieldAccessor : igVscColorAccessor
    {
        [FieldAttr(nst: 24, ctr: 16, refCount: false)] public igVec4ucMetaFieldInstance? _metaField;
    }
}
