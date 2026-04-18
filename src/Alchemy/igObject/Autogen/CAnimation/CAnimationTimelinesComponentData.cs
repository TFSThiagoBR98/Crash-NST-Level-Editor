namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 8)]
    public class CAnimationTimelinesComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public string? _animationEventsFile = null;
    }
}
