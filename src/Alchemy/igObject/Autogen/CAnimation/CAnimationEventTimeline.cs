namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 8)]
    public class CAnimationEventTimeline : CCharacterEventTimeline
    {
        [FieldAttr(nst: 32)] public bool _startAtCurrentTimeWhenActivated;
    }
}
