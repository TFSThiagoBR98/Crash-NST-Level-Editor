namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class CBehaviorComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24, ctr: 16)] public string? _behaviorFile = null;
        [FieldAttr(nst: 32, ctr: 24)] public string? _behaviorEventsFile = null;
        [FieldAttr(nst: 40, ctr: 32)] public string? _startState = null;
        [FieldAttr(nst: 48, ctr: 40)] public CBehaviorEventFilterData? _eventFilterData;
        [FieldAttr(nst: 56, ctr: 48)] public CBehaviorLogicDataTable? _handlers;
    }
}
