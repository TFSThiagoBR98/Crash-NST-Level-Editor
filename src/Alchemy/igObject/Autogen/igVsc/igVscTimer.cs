namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8, metaType: typeof(igUpdateable))]
    public class igVscTimer : igUpdateable
    {
        [FieldAttr(nst: 32)] public igHandleMetaField _delegateThis = new();
        [FieldAttr(nst: 40)] public igHandleMetaField _finishedDelegate = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _abortedDelegate = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _remainingDelegate = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _updater = new();
        [FieldAttr(nst: 72)] public float _duration;
        [FieldAttr(nst: 76)] public bool _resetOnStart;
        [FieldAttr(nst: 77)] public bool _isRunning;
        [FieldAttr(nst: 80)] public float _timeRemaining;
    }
}
