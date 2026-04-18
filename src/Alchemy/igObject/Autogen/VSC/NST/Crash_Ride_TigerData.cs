namespace Alchemy
{
    [ObjectAttr(nst: 192, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_Ride_TigerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _ReverseMovementMultiplier;
        [FieldAttr(nst: 44)] public float _Float_0x2c;
        [FieldAttr(nst: 48)] public string? _RideLCRBlendWeight = null;
        [FieldAttr(nst: 56)] public string? _RideLandEvent = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Zone_Info_0x40 = new();
        [FieldAttr(nst: 72)] public float _AmountToAdd;
        [FieldAttr(nst: 80)] public igHandleMetaField _Behavior_State_Group_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Zone_Info_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _HogRiderBolt = new();
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 112)] public igHandleMetaField _Behavior_State_Group_0x70 = new();
        [FieldAttr(nst: 120)] public float _Float_0x78;
        [FieldAttr(nst: 128)] public igHandleMetaField _Zone_Info_0x80 = new();
        [FieldAttr(nst: 136)] public float _Float_0x88;
        [FieldAttr(nst: 144)] public igHandleMetaField _Entity_Tag = new();
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 156)] public float _Float_0x9c;
        [FieldAttr(nst: 160)] public float _MaxDeathVelocity;
        [FieldAttr(nst: 164)] public float _Float_0xa4;
        [FieldAttr(nst: 168)] public float _Float_0xa8;
        [FieldAttr(nst: 172)] public float _Float_0xac;
        [FieldAttr(nst: 176)] public float _Float_0xb0;
        [FieldAttr(nst: 180)] public float _Float_0xb4;
        [FieldAttr(nst: 184)] public igHandleMetaField _Shape = new();
    }
}
