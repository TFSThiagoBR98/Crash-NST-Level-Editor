namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class igVscIndirectColorPropertyAccessor : igVscColorAccessor
    {
        [FieldAttr(ctr: 16)] public igVscObjectAccessor? _object;
        [FieldAttr(ctr: 24, refCount: false)] public igMetaFunction? _get;
        [FieldAttr(ctr: 32, refCount: false)] public igMetaFunction? _set;
    }
}
