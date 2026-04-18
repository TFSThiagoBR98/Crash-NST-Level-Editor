namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CGuiBehaviorLinearRacingMinimap : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public igNonRefCountedGuiPlaceableList? _racerHud;
        [FieldAttr(ctr: 24)] public igVec3fMetaField _startPosition = new();
        [FieldAttr(ctr: 36)] public igVec3fMetaField _endPosition = new();
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _warpOrbAsset;
        [FieldAttr(ctr: 56)] public CGuiEventLinearRacingMinimapRacerSetup? _racerSetupEvent;
        [FieldAttr(ctr: 64)] public igFloatList? _mapRatios;
        [FieldAttr(ctr: 72)] public igGuiPlaceableList? _despawnList;
    }
}
