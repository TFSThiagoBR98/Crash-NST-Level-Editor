namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CCEVehicleFakeFullThrottle : CCombatNodeEvent
    {
        public enum EThrottleEventType
        {
            eTET_Start = 0,
            eTET_Stop = 1,
        }

        [FieldAttr(nst: 80)] public EThrottleEventType _eventType;
        [FieldAttr(nst: 84)] public float _enableTimerDuration = -1.0f;
        [FieldAttr(nst: 88)] public bool _enableTimerCanPause = true;
    }
}
