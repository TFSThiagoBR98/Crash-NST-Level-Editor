namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class L100_Hub_CortexCastle_UnlockStormy_AscentData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public EZoneCollectibleType _E_Zone_Collectible_Type;
        [FieldAttr(nst: 48)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Game_Bool_Variable_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Game_Bool_Variable_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Entity_0x60 = new();
    }
}
