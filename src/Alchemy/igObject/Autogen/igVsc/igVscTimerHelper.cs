namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 88, align: 8)]
    public class igVscTimerHelper : igVscPlaceable
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVscObjectAccessor? _timer;
        [FieldAttr(nst: 24, ctr: 24)] public igVscObjectAccessor? _updater;
        [FieldAttr(nst: 32, ctr: 32)] public igVscFloatAccessor? _duration;
        [FieldAttr(nst: 40, ctr: 40)] public igVscBoolAccessor? _resetOnStart;
        [FieldAttr(nst: 48, ctr: 48)] public igVscFloatAccessor? _timeToAdd;
        [FieldAttr(ctr: 56)] public igVscBoolAccessor? _loop;
        [FieldAttr(nst: 56, ctr: 64, refCount: false)] public igVscMethod? _finished;
        [FieldAttr(nst: 64, ctr: 72, refCount: false)] public igVscMethod? _aborted;
        [FieldAttr(nst: 72, ctr: 80)] public igVscMethod? _remaining;
    }
}
