namespace Alchemy
{
    [ObjectAttr(nst: 272, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crash1_Hub_ManagerData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _CrashHub = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _SecretMapSpotList = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _AllIsleMapSpotList = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _IsleDataList = new();
        [FieldAttr(nst: 72)] public float _CrashHubDelayMoveToNextSpotOnLevelProgressStart;
        [FieldAttr(nst: 76)] public float _IsleTransitionCrashHubDelay;
        [FieldAttr(nst: 80)] public float _CrashInputLeftStickToleranceMin;
        [FieldAttr(nst: 88)] public igHandleMetaField _GuiHubProjectData = new();
        [FieldAttr(nst: 96)] public igKeyboardInputDevice.ESignal _DebugInputCollectAllGemsKeys;
        [FieldAttr(nst: 104)] public igHandleMetaField _CrashHubMinigamePreset = new();
        [FieldAttr(nst: 112)] public EXBUTTON _CrashHubInputMapSelect;
        [FieldAttr(nst: 116)] public EXBUTTON _CrashHubInputCameraSplinePlayForward_0x74;
        [FieldAttr(nst: 120)] public EXBUTTON _CrashHubInputCameraSplinePlayBackward;
        [FieldAttr(nst: 128)] public igHandleMetaField _Gui_Project = new();
        [FieldAttr(nst: 136)] public EXBUTTON _CrashHubInputCameraSplinePlayForward_0x88;
        [FieldAttr(nst: 144)] public igHandleMetaField _Sound_0x90 = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Sound_0x98 = new();
        [FieldAttr(nst: 160)] public EXBUTTON _CrashHubInputCameraSplinePlayForward_0xa0;
        [FieldAttr(nst: 168)] public igHandleMetaField _Game_Int_Variable_0xa8 = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Game_Bool_Variable_0xb0 = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _Game_Bool_Variable_0xb8 = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _Vfx_Effect_0xc0 = new();
        [FieldAttr(nst: 200)] public igHandleMetaField _Vfx_Effect_0xc8 = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _Zone_Info = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _Entity_0xd8 = new();
        [FieldAttr(nst: 224)] public igHandleMetaField _Entity_0xe0 = new();
        [FieldAttr(nst: 232)] public igHandleMetaField _Localized_String = new();
        [FieldAttr(nst: 240)] public float _Float;
        [FieldAttr(nst: 248)] public igHandleMetaField _Game_Int_Variable_0xf8 = new();
        [FieldAttr(nst: 256)] public string? _String = null;
        [FieldAttr(nst: 264)] public EXBUTTON _CrashHubInputCameraSplinePlayForward_0x108;
    }
}
