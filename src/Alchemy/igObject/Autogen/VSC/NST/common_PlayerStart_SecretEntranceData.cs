namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_PlayerStart_SecretEntranceData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Int_Variable = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Camera_Base = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Fade_In_Preset_Data_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Fade_In_Preset_Data_0x40 = new();
    }
}
