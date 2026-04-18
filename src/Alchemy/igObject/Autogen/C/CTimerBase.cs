namespace Alchemy
{
    [ObjectAttr(nst: 32, ctr: 24, align: 8)]
    public class CTimerBase : igObject
    {
        [FieldAttr(nst: 16, ctr: 12)] public igTimeMetaField _startTime = new();
        [FieldAttr(nst: 20, ctr: 16)] public igTimeMetaField _stopTime = new();
        [FieldAttr(nst: 24, ctr: 20)] public bool _isRunning;
        [FieldAttr(nst: 25, ctr: 21)] public bool _isPaused;
    }
}
