namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class BossNBrio_IdleTimeOutData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _TimeOutRangeMin;
        [FieldAttr(nst: 44)] public float _TimeOutRangeMax;
        [FieldAttr(nst: 48)] public igHandleMetaField _BehaviorEventTimeOutList = new();
    }
}
