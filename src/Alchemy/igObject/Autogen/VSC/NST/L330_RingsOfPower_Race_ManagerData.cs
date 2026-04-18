namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class L330_RingsOfPower_Race_ManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_List = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(nst: 80)] public string? _String = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Debug_Update_Channel = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 112)] public EZoneCollectibleType _E_Zone_Collectible_Type;
    }
}
