namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 72, align: 8)]
    public class CTakeHitLogic : CBehaviorLogic
    {
        [FieldAttr(nst: 80, ctr: 64)] public bool _allowMultiplePushbacks;
        [FieldAttr(nst: 84, ctr: 68)] public float _pushbackScale = 1.0f;
    }
}
