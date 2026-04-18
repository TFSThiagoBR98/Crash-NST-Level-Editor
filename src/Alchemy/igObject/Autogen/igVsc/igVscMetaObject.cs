namespace Alchemy
{
    [ObjectAttr(nst: 200, ctr: 200, align: 8)]
    public class igVscMetaObject : igDynamicMetaObject
    {
        [FieldAttr(nst: 152, ctr: 152, refCount: false)] public igVscMethodList? _exposedMethods;
        [FieldAttr(nst: 160, ctr: 160, refCount: false)] public igVscDelegatorList? _delegators;
        [FieldAttr(nst: 168)] public igRawRefMetaField _delegatesEnabledCallback = new();
        [FieldAttr(nst: 176, ctr: 176, refCount: false)] public igMetaObject? _dataMeta;
        [FieldAttr(nst: 184, ctr: 184)] public igVscDelegatorList? _privateMessageDelegatorList;
        [FieldAttr(nst: 192, ctr: 192)] public bool _registeredPrivateMessages;
    }
}
