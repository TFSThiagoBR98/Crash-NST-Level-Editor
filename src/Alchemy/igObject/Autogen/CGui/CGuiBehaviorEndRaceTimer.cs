namespace Alchemy
{
    [ObjectAttr(ctr: 72, align: 8)]
    public class CGuiBehaviorEndRaceTimer : igGuiBehavior
    {
        [FieldAttr(ctr: 16, refCount: false)] public igGuiAnimationTag? _endRaceTimerTimeLowAnim;
        [FieldAttr(ctr: 24, refCount: false)] public igGuiAnimationTag? _allLocalRacersFinishedAnim;
        [FieldAttr(ctr: 32)] public igGuiAnimationCategory? _animationLowTimeCategory;
        [FieldAttr(ctr: 40)] public igGuiAnimationCategory? _animationLocalPlayersFinishedCategory;
        [FieldAttr(ctr: 48)] public float _lowTimeAnimationStartTime;
        [FieldAttr(ctr: 52)] public float _ttrMultiplier;
        [FieldAttr(ctr: 56)] public int _secondsRemainingLastFrame;
        [FieldAttr(ctr: 60)] public float _onlineEndRaceTimeRemaining;
        [FieldAttr(ctr: 64)] public bool _raceFinished;
        [FieldAttr(ctr: 65)] public bool _onlineEndRaceTimerStarted;
        [FieldAttr(ctr: 66)] public bool _lowTimeAnimStarted;
    }
}
