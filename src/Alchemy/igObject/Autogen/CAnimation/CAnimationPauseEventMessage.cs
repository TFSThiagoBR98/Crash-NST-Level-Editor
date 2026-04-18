namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 8)]
    public class CAnimationPauseEventMessage : CAnimationEventMessage
    {
        [FieldAttr(nst: 96)] public bool _isPaused;
    }
}
