namespace Alchemy
{
    [ObjectAttr(nst: 200, align: 4, metaType: typeof(CVscComponentData))]
    public class Crash_Ride_BoardData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _BoardRiderBolt = new();
        [FieldAttr(nst: 48)] public float _BoostVelocity;
        [FieldAttr(nst: 52)] public igVec3fMetaField _Vec_3F = new();
        [FieldAttr(nst: 64)] public string? _RideBoardDismountCustomEvent = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Behavior_State_Group_0x48 = new();
        [FieldAttr(nst: 80)] public float _Float_0x50;
        [FieldAttr(nst: 84)] public float _Float_0x54;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 92)] public float _Float_0x5c;
        [FieldAttr(nst: 96)] public float _Float_0x60;
        [FieldAttr(nst: 100)] public float _Float_0x64;
        [FieldAttr(nst: 104)] public float _Float_0x68;
        [FieldAttr(nst: 108)] public float _Float_0x6c;
        [FieldAttr(nst: 112)] public igHandleMetaField _Game_Bool_Variable_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Game_Bool_Variable_0x78 = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Behavior_State_Group_0x80 = new();
        [FieldAttr(nst: 136)] public float _Float_0x88;
        [FieldAttr(nst: 140)] public float _Float_0x8c;
        [FieldAttr(nst: 144)] public float _Float_0x90;
        [FieldAttr(nst: 148)] public float _Float_0x94;
        [FieldAttr(nst: 152)] public float _Float_0x98;
        [FieldAttr(nst: 156)] public float _Float_0x9c;
        [FieldAttr(nst: 160)] public igHandleMetaField _Debug_Update_Channel = new();
        [FieldAttr(nst: 168)] public float _UMDAddPerFrameValue;
        [FieldAttr(nst: 176)] public igHandleMetaField _Vfx_Effect_0xb0 = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _Vfx_Effect_0xc0 = new();
    }
}
