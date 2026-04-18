namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CNetworkAnimationStateEntryTable : igObject
    {
        [FieldAttr(nst: 16)] public igStringRefList? _prerequisiteStates;
        [FieldAttr(nst: 24)] public string? _mainStateEntryEvent = null;
        [FieldAttr(nst: 32)] public string? _mainStateExitEvent = null;
        [FieldAttr(nst: 40)] public string? _componentSetStateMethod = null;
        [FieldAttr(nst: 48)] public string? _componentGetStateMethod = null;
        [FieldAttr(nst: 56)] public igStringRefList? _subStates;
        [FieldAttr(nst: 64, refCount: false)] public igMetaObject? _componentTypeSetState;
        [FieldAttr(nst: 72, refCount: false)] public igMetaFunction? _componentSetStateFunction;
        [FieldAttr(nst: 80, refCount: false)] public igMetaObject? _componentTypeGetState;
        [FieldAttr(nst: 88, refCount: false)] public igMetaFunction? _componentGetStateFunction;
    }
}
