namespace Alchemy
{
    [ObjectAttr(nst: 144, ctr: 144, align: 8)]
    public class igNetTask : igObject
    {
        [FieldAttr(nst: 16, ctr: 16, refCount: false)] public igNetTaskQueue? _parentQueue;
        [FieldAttr(nst: 24, ctr: 24, refCount: false)] public igNetTask? _parentTask;
        [FieldAttr(nst: 32, ctr: 32)] public igRawRefMetaField _callingObject = new();
        [FieldAttr(nst: 40, ctr: 48)] public uint _completionCallback;
        [FieldAttr(nst: 104, ctr: 96)] public float _timeoutInSeconds;
        [FieldAttr(nst: 108, ctr: 100)] public bool _timeoutElapsed;
        [FieldAttr(nst: 112, ctr: 104)] public int _errorCode;
        [FieldAttr(nst: 116, ctr: 108)] public bool _canceled;
        [FieldAttr(nst: 117, ctr: 109)] public bool _terminateWhenCanceled = true;
        [FieldAttr(nst: 118, ctr: 110)] public bool _autoPropagateErrors;
        [FieldAttr(nst: 120, ctr: 112)] public string? _taskType = "NetworkTask";
        [FieldAttr(nst: 128, ctr: 120)] public igRawRefMetaField _userParam = new();
        [FieldAttr(nst: 136, ctr: 128)] public igTimeMetaField _taskStartTime = new();
    }
}
