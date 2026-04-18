namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class Enemy_Pause_Patrol_Player_CheckData : CVscComponentData
    {
        public enum ELocalOffsetStopCondition
        {
            StopWhenXNegative = 0,
            StopWhenXPositive = 1,
            StopWhenYNegative = 2,
            StopWhenYPositive = 3,
            StopWhenZNegative = 4,
            StopWhenZPositive = 5,
        }

        [FieldAttr(nst: 40)] public bool _DisableMotionRelativePos;
        [FieldAttr(nst: 41)] public bool _DisableMotionOnDistance;
        [FieldAttr(nst: 44)] public ELocalOffsetStopCondition _LocalOffsetStopCondition;
        [FieldAttr(nst: 48)] public float _MinRange;
        [FieldAttr(nst: 52)] public float _MaxRange;
        [FieldAttr(nst: 56)] public float _CompareValue;
    }
}
