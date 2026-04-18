namespace Alchemy
{
    [ObjectAttr(nst: 224, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_Ride_BearData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _RideLCRBlendWeight_0x28 = null;
        [FieldAttr(nst: 48)] public string? _RideLandEvent = null;
        [FieldAttr(nst: 56)] public float _MaxDeathVelocity;
        [FieldAttr(nst: 60)] public float _MinDeathVelocity;
        [FieldAttr(nst: 64)] public float _AmountToAdd;
        [FieldAttr(nst: 72)] public igHandleMetaField _Entity_Tag_0x48 = new();
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 88)] public igHandleMetaField _HogRiderBolt_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Behavior_State_Group_0x60 = new();
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 108)] public float _Float_0x6c;
        [FieldAttr(nst: 112)] public igHandleMetaField _Behavior_State_Group_0x70 = new();
        [FieldAttr(nst: 120)] public float _ReverseMovementMultiplier;
        [FieldAttr(nst: 128)] public igHandleMetaField _Entity_Tag_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 144)] public igHandleMetaField _Zone_Info_0x90 = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Zone_Info_0x98 = new();
        [FieldAttr(nst: 160)] public igHandleMetaField _Zone_Info_0xa0 = new();
        [FieldAttr(nst: 168)] public igHandleMetaField _Zone_Info_0xa8 = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Zone_Info_0xb0 = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _HogRiderBolt_0xb8 = new();
        [FieldAttr(nst: 192)] public float _Float_0xc0;
        [FieldAttr(nst: 196)] public float _Float_0xc4;
        [FieldAttr(nst: 200)] public float _Float_0xc8;
        [FieldAttr(nst: 208)] public string? _RideLCRBlendWeight_0xd0 = null;
        [FieldAttr(nst: 216)] public igHandleMetaField _Debug_Update_Channel = new();
    }
}
