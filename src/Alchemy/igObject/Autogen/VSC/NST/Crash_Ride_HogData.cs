namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_Ride_HogData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _HogRiderBolt = new();
        [FieldAttr(nst: 48)] public float _MinDeathVelocity;
        [FieldAttr(nst: 52)] public float _AmountToAdd;
        [FieldAttr(nst: 56)] public string? _RideLCRBlendWeight = null;
        [FieldAttr(nst: 64)] public string? _RideLandEvent = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Behavior_State_Group = new();
        [FieldAttr(nst: 80)] public float _MaxDeathVelocity;
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 96)] public float _Float;
        [FieldAttr(nst: 104)] public igHandleMetaField _Zone_Info_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Zone_Info_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Zone_Info_0x78 = new();
    }
}
