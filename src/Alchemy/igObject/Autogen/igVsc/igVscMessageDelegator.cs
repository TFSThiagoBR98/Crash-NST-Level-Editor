namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igVscMessageDelegator : igVscDelegator
    {
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igMetaObject? _messageMetaObject;
        [FieldAttr(nst: 32, ctr: 32)] public igVscObjectAccessor? _target;
        [FieldAttr(nst: 40, ctr: 40)] public bool _isPrivateMessage;
    }
}
