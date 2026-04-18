namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CGuiBehaviorHUBMinimap : igGuiBehavior
    {
        [FieldAttr(ctr: 16)] public igNonRefCountedGuiPlaceableList? _arenaRaceIcons;
        [FieldAttr(ctr: 24)] public igNonRefCountedGuiPlaceableList? _bossIcons;
        [FieldAttr(ctr: 32)] public igNonRefCountedGuiPlaceableList? _saveIcons;
        [FieldAttr(ctr: 40)] public igNonRefCountedGuiPlaceableList? _exitIcons;
        [FieldAttr(ctr: 48, refCount: false)] public igGuiPlaceable? _playerIcon;
        [FieldAttr(ctr: 56, refCount: false)] public igGuiPlaceable? _minimap;
        [FieldAttr(ctr: 64)] public igVec2fMetaField _topLeft = new();
        [FieldAttr(ctr: 72)] public igVec2fMetaField _bottomRight = new();
        [FieldAttr(ctr: 80)] public int _arenaRaceIndex;
        [FieldAttr(ctr: 84)] public int _bossIndex;
        [FieldAttr(ctr: 88)] public int _saveIndex;
        [FieldAttr(ctr: 92)] public int _exitIndex;
    }
}
