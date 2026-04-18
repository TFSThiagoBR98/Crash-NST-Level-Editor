namespace Alchemy
{
    [ObjectAttr(ctr: 80, align: 8)]
    public class CGuiBehaviorAnimateWumpaPlaceable : CGuiBehaviorAnimatePlaceable
    {
        [FieldAttr(ctr: 64)] public string? _wumpaFruitCountString;
        [FieldAttr(ctr: 72)] public int _wumpaFruitCount;
    }
}
