namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CLoadHeroesAction : CSmokeActionBase
    {
        [FieldAttr(ctr: 40)] public string? _map;
        [FieldAttr(ctr: 48)] public string? _checkpointName;
        [FieldAttr(ctr: 56)] public bool _dynamicHeroes;
        [FieldAttr(ctr: 64)] public igStringRefListList? _heroCombinations;
        [FieldAttr(ctr: 72)] public int _numHeroesToSpawn;
        [FieldAttr(ctr: 76)] public bool _initialized;
        [FieldAttr(ctr: 80)] public igStringRefList? _currentHeroList;
        [FieldAttr(ctr: 88)] public int _numPartsSwapped;
        [FieldAttr(ctr: 92)] public EPlayerId _playerId;
        [FieldAttr(ctr: 96)] public ELoadHeroesActionState _state;
        [FieldAttr(ctr: 100)] public int _previousDefaultNumHeroesToSpawn;
    }
}
