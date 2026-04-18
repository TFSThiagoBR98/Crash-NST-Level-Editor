namespace Alchemy
{
    [ObjectAttr(nst: 40, ctr: 40, align: 8)]
    public class CBehaviorEventTimeline : CCharacterEventTimeline
    {
        [FieldAttr(nst: 32, ctr: 32)] public bool _disableWhenAnimationOverridden;
        [FieldAttr(nst: 33, ctr: 33)] public bool _startAtCurrentTimeWhenActivated;
        [FieldAttr(nst: 36, ctr: 36)] public float _layerWeightThreshhold;
    }
}
