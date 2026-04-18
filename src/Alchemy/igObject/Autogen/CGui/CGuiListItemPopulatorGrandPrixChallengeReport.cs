namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiListItemPopulatorGrandPrixChallengeReport : igGuiListItemPopulator
    {
        [FieldAttr(ctr: 12)] public float _delayBetweenChallenge;
        [FieldAttr(ctr: 16)] public int _maxChallengeShown;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiPlaceable? _loadingIconPlaceable;
        [FieldAttr(ctr: 32, refCount: false)] public igGuiPlaceable? _noChallengePlaceable;
        [FieldAttr(ctr: 40)] public igTimeMetaField _delayBetweenChallengeTimer = new();
        [FieldAttr(ctr: 44)] public igTimeMetaField _serverWaitTimeoutTimer = new();
        [FieldAttr(ctr: 48)] public bool _timeoutReached;
        [FieldAttr(ctr: 52)] public int _completedChallengeShown;
        [FieldAttr(ctr: 56)] public bool _listingDone;
    }
}
