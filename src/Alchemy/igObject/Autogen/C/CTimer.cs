namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 32, align: 8)]
    public class CTimer : CTimerBase
    {
        [FieldAttr(nst: 32, ctr: 24)] public ETimerType _timerType;
    }
}
