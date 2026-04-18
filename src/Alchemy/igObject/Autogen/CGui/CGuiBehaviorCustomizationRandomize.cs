namespace Alchemy
{
    [ObjectAttr(ctr: 152, align: 8)]
    public class CGuiBehaviorCustomizationRandomize : CGuiBehavior
    {
        [FieldAttr(ctr: 140)] public float _randomizationDelay;
        [FieldAttr(ctr: 144)] public CTimer? _inputDelayTimer;
    }
}
