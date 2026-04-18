namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_VehicleBase_SimulateHoldAttackData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Activators = new();
        [FieldAttr(nst: 48)] public float _ShortHold;
        [FieldAttr(nst: 52)] public float _LongHold;
        [FieldAttr(nst: 56)] public string? _FireOutEvent = null;
    }
}
