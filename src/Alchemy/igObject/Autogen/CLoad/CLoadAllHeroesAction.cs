namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class CLoadAllHeroesAction : CSmokeActionBase
    {
        [FieldAttr(ctr: 40)] public igStringRefList? _exclusions;
        [FieldAttr(ctr: 48)] public int _numPlayers;
        [FieldAttr(ctr: 52)] public bool _doScreenGrab;
        [FieldAttr(ctr: 53)] public bool _doVariants;
        [FieldAttr(ctr: 56)] public int _numHeroesProcessed;
        [FieldAttr(ctr: 60)] public int _numCoopHeroesProcessed;
        [FieldAttr(ctr: 64)] public int _numVariantsProcessed;
        [FieldAttr(ctr: 68)] public EPlayerId _playerId;
        [FieldAttr(ctr: 72)] public ELoadAllHeroesActionState _state;
        [FieldAttr(ctr: 80)] public igStringRefList? _heroList;
        [FieldAttr(ctr: 88)] public CHeroScreenGrabAction? _heroScreenGrabAction;
        [FieldAttr(ctr: 96)] public bool _initialized;
    }
}
