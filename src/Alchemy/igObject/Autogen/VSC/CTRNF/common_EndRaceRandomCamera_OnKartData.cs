namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 4, metaType: typeof(CVscComponentData))]
    public class common_EndRaceRandomCamera_OnKartData : CVscComponentData
    {
        [FieldAttr(ctr: 32)] public igHandleMetaField _Fade_In_Preset_Data = new();
        [FieldAttr(ctr: 40)] public igHandleMetaField _Fade_Out_Preset_Data = new();
        [FieldAttr(ctr: 48)] public igHandleMetaField _Int_List = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _Havok_Linear_Cast_Query_Parameters = new();
    }
}
