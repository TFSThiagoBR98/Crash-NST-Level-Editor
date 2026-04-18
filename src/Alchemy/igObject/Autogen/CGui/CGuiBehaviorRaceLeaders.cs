namespace Alchemy
{
    [ObjectAttr(ctr: 64, align: 8)]
    public class CGuiBehaviorRaceLeaders : igGuiBehavior
    {
        [FieldAttr(ctr: 12)] public bool _visibleDuringRace;
        [FieldAttr(ctr: 16)] public igNonRefCountedGuiPlaceableList? _racers;
        [FieldAttr(ctr: 24)] public float _animationTime;
        [FieldAttr(ctr: 28)] public float _translateAmountX;
        [FieldAttr(ctr: 32)] public EigEaseType _easeType;
        [FieldAttr(ctr: 36)] public EigEaseMode _easeMode;
        [FieldAttr(ctr: 40)] public CGUIEventAnimateRaceLeaderItems? _raceLeadersAnimateEvent;
        [FieldAttr(ctr: 48)] public bool _hasRaceStarted;
        [FieldAttr(ctr: 56)] public CPositionPortraitAnimationInfoList? _positionPortraitAnimationInfoList;
    }
}
