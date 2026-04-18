namespace Alchemy
{
    [ObjectAttr(ctr: 56, align: 8)]
    public class CGuiBehaviorSpawnPlaceable : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiPlaceable? _spawnTemplate;
        [FieldAttr(ctr: 24)] public igVec3fMetaField _endPositionOffset = new();
        [FieldAttr(ctr: 36)] public igVec3fMetaField _startPositionOffset = new();
        [FieldAttr(ctr: 48)] public igGuiPlaceableList? _despawnList;
    }
}
