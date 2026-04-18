namespace Alchemy
{
    [ObjectAttr(ctr: 152, align: 8)]
    public class CGuiBehaviorRacingMinimap : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public igNonRefCountedGuiPlaceableList? _racerHud;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _minimapHud;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiSharedAssetProject? _warpOrbAsset;
        [FieldAttr(ctr: 40, refCount: false)] public igGuiPlaceable? _splitscreenBackground;
        [FieldAttr(ctr: 48)] public igVec2fMetaField _topLeft = new();
        [FieldAttr(ctr: 56)] public igVec2fMetaField _bottomRight = new();
        [FieldAttr(ctr: 64)] public ERacingMinimapDirection _minimapDirection;
        [FieldAttr(ctr: 68)] public igVec3fMetaField _singleClassicPosition = new();
        [FieldAttr(ctr: 80)] public igVec3fMetaField _singleSpeedometerPosition = new();
        [FieldAttr(ctr: 92)] public igVec3fMetaField _singleNitroFueledPosition = new();
        [FieldAttr(ctr: 104)] public igVec3fMetaField _splitscreenPosition = new();
        [FieldAttr(ctr: 116)] public igVec3fMetaField _verticalSplitscreenPosition = new();
        [FieldAttr(ctr: 128)] public CGuiEventRacingMinimapRacerSetup? _racerSetupEvent;
        [FieldAttr(ctr: 136)] public CGuiEventRacingMinimapGhostSetup? _ghostSetupEvent;
        [FieldAttr(ctr: 144)] public igGuiPlaceableList? _despawnList;
    }
}
