namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 8)]
    public class CCEAnimateBoltons : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public EBoltonModels _targetBolton = EBoltonModels.EBOLTON_NONE;
        [FieldAttr(nst: 88)] public string? _animationName = null;
        [FieldAttr(nst: 96)] public float _playbackSpeed = 1.0f;
        [FieldAttr(nst: 100)] public bool _looping;
        [FieldAttr(nst: 104)] public float _blendTime = 0.1f;
    }
}
