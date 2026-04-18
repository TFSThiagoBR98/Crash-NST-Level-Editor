namespace Alchemy
{
    [ObjectAttr(ctr: 40, align: 8)]
    public class CAnimateEntityComponentData : CEntityComponentData
    {
        [FieldAttr(ctr: 16)] public bool _playAnimationToSelf;
        [FieldAttr(ctr: 24)] public string? _animationToPlay;
        [FieldAttr(ctr: 32)] public bool _isLooping;
        [FieldAttr(ctr: 33)] public bool _playOnEnable;
        [FieldAttr(ctr: 34)] public bool _resetOnActivate;
    }
}
