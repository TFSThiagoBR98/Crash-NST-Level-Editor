namespace Alchemy
{
    [ObjectAttr(nst: 48, align: 8)]
    public class CGuiTimerData : igObject
    {
        [FieldAttr(nst: 16)] public CTimer? _timer;
        [FieldAttr(nst: 24)] public float _timerDuration;
        [FieldAttr(nst: 32)] public igHandleMetaField _entity = new();
        [FieldAttr(nst: 40)] public CBoltPoint? _boltPoint;
    }
}
