namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igVscMetaFunctionDelegator : igVscDelegator
    {
        [FieldAttr(nst: 24, ctr: 24)] public igVscObjectAccessor? _target;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igMetaFunction? _registerMetaFunction;
        [FieldAttr(nst: 40, ctr: 40, refCount: false)] public igMetaFunction? _unregisterMetaFunction;
    }
}
