namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 80, align: 8)]
    public class igVscSendMessageNode : igVscActionNode
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igMetaObject? _messageMetaObject;
        [FieldAttr(nst: 24, ctr: 24)] public igVscObjectAccessor? _target;
        [FieldAttr(nst: 32, ctr: 32)] public igVscAccessorList? _accessors;
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<igMetaFieldInstance> _metaFields = new();
        [FieldAttr(nst: 64, ctr: 64)] public bool _isPrivateMessage;
        [FieldAttr(nst: 72, ctr: 72, refCount: false)] public igVscActionNode? _out;
    }
}
