namespace Alchemy
{
    [ObjectAttr(ctr: 192, align: 8)]
    public class CWorldCustomizationComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public float _characterRotationSpeed;
        [FieldAttr(ctr: 24)] public CWaypointList? _spawnPositions1P;
        [FieldAttr(ctr: 32)] public igHandleMetaField _overrideCamera1P = new();
        [FieldAttr(ctr: 40)] public string? _menuName1P;
        [FieldAttr(ctr: 48)] public igHandleMetaField _background1P = new();
        [FieldAttr(ctr: 56)] public igHandleMetaField _backgroundPattern1P = new();
        [FieldAttr(ctr: 64)] public igHandleMetaField _backgroundPatternAdventure = new();
        [FieldAttr(ctr: 72)] public igHandleMetaField _backgroundPatternPitstop = new();
        [FieldAttr(ctr: 80)] public CGameEntityHandleList? _additionnalEntities1P;
        [FieldAttr(ctr: 88)] public igEntityHandleList? _pelletEntityList;
        [FieldAttr(ctr: 96)] public CWaypointList? _spawnPositions2P;
        [FieldAttr(ctr: 104)] public igHandleMetaField _overrideCamera2P = new();
        [FieldAttr(ctr: 112)] public string? _menuName2P;
        [FieldAttr(ctr: 120)] public CWaypointList? _spawnPositions3P;
        [FieldAttr(ctr: 128)] public igHandleMetaField _overrideCamera3P = new();
        [FieldAttr(ctr: 136)] public string? _menuName3P;
        [FieldAttr(ctr: 144)] public CWaypointList? _spawnPositions4P;
        [FieldAttr(ctr: 152)] public igHandleMetaField _overrideCamera4P = new();
        [FieldAttr(ctr: 160)] public string? _menuName4P;
        [FieldAttr(ctr: 168)] public CDriverCustomBackgroundEntityTable? _driverCustomBackgroundEntities;
        [FieldAttr(ctr: 176)] public CDriverCustomAmbienceSFXTable? _driverCustomAmbienceSFXList;
        [FieldAttr(ctr: 184)] public string? _teamSelectMenuName;
    }
}
