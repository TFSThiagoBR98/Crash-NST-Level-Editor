namespace Alchemy
{
    [ObjectAttr(nst: 296, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crash1_Hub_MapSpotData : CVscComponentData
    {
        public enum EInputMapDirectionRight
        {
            PreviousMap = 0,
            NextMap = 1,
            ToSecretMap = 2,
            FromSecretMap = 3,
            None = 4,
            ShortcutForward = 5,
            ShortcutBackward = 6,
        }

        public enum EInputMapDirectionUp
        {
            PreviousMap = 0,
            NextMap = 1,
            ToSecretMap = 2,
            FromSecretMap = 3,
            None = 4,
            ShortcutForward = 5,
            ShortcutBackward = 6,
        }

        public enum EInputMapDirectionLeft
        {
            PreviousMap = 0,
            NextMap = 1,
            ToSecretMap = 2,
            FromSecretMap = 3,
            None = 4,
            ShortcutForward = 5,
            ShortcutBackward = 6,
        }

        public enum EInputMapDirectionDown
        {
            PreviousMap = 0,
            NextMap = 1,
            ToSecretMap = 2,
            FromSecretMap = 3,
            None = 4,
            ShortcutForward = 5,
            ShortcutBackward = 6,
        }

        [FieldAttr(nst: 40)] public igHandleMetaField _SecretMapSpotSpline = new();
        [FieldAttr(nst: 48)] public EInputMapDirectionRight _InputMapDirectionRight;
        [FieldAttr(nst: 52)] public EInputMapDirectionUp _InputMapDirectionUp;
        [FieldAttr(nst: 56)] public EInputMapDirectionLeft _InputMapDirectionLeft;
        [FieldAttr(nst: 60)] public EInputMapDirectionDown _InputMapDirectionDown;
        [FieldAttr(nst: 64)] public igHandleMetaField _MapLoadFadeOut = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _PathToUnlockMaterialOverride = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _MapSpotSplineMarker = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _CameraSplineMarker = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _VfxMapUnlockIdleData = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _MapZoneInfo = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _PathTo = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Gui_Animation_Tag = new();
        [FieldAttr(nst: 128)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 136)] public EZoneCollectibleType _E_Zone_Collectible_Type_0x88;
        [FieldAttr(nst: 140)] public bool _Bool_0x8c;
        [FieldAttr(nst: 144)] public igHandleMetaField _Zone_Info_0x90 = new();
        [FieldAttr(nst: 152)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 160)] public EZoneCollectibleType _E_Zone_Collectible_Type_0xa0;
        [FieldAttr(nst: 168)] public igHandleMetaField _Localized_String = new();
        [FieldAttr(nst: 176)] public igHandleMetaField _Game_Float_Variable = new();
        [FieldAttr(nst: 184)] public igHandleMetaField _common_C2_WarpRoom_LevelPortalDatas025 = new();
        [FieldAttr(nst: 192)] public igHandleMetaField _common_C2_WarpRoom_LevelPortalDatas023_0xc0 = new();
        [FieldAttr(nst: 200)] public igHandleMetaField _common_C2_WarpRoom_LevelPortalDatas026 = new();
        [FieldAttr(nst: 208)] public igHandleMetaField _common_C2_WarpRoom_LevelPortalDatas023_0xd0 = new();
        [FieldAttr(nst: 216)] public igHandleMetaField _common_C2_WarpRoom_LevelPortalDatas027 = new();
        [FieldAttr(nst: 224)] public igHandleMetaField _common_C2_WarpRoom_LevelPortalDatas022 = new();
        [FieldAttr(nst: 232)] public bool _Bool_0xe8;
        [FieldAttr(nst: 240)] public igHandleMetaField _Entity_0xf0 = new();
        [FieldAttr(nst: 248)] public igHandleMetaField _Entity_0xf8 = new();
        [FieldAttr(nst: 256)] public igHandleMetaField _Zone_Info_0x100 = new();
        [FieldAttr(nst: 264)] public igHandleMetaField _Entity_0x108 = new();
        [FieldAttr(nst: 272)] public igHandleMetaField _Entity_0x110 = new();
        [FieldAttr(nst: 280)] public igHandleMetaField _Entity_0x118 = new();
        [FieldAttr(nst: 288)] public igHandleMetaField _Entity_0x120 = new();
    }
}
