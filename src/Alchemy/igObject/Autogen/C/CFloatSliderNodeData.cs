namespace Alchemy
{
    [ObjectAttr(nst: 152, align: 8)]
    public class CFloatSliderNodeData : igObject
    {
        [FieldAttr(nst: 16)] public CSlider? _slider;
        [FieldAttr(nst: 24)] public igVscDelegateMetaField _reachedStartCallback = new();
        [FieldAttr(nst: 40)] public igVscDelegateMetaField _updatingCallback = new();
        [FieldAttr(nst: 56)] public igVscDelegateMetaField _reachedEndCallback = new();
        [FieldAttr(nst: 72)] public igVscFloatDelegateMetaField _currentValue = new();
        [FieldAttr(nst: 88)] public igRawRefMetaField _onUpdate = new();
        [FieldAttr(nst: 96)] public igRawRefMetaField _onCompletion = new();
        [FieldAttr(nst: 104)] public igRawRefMetaField _onStartReached = new();
        [FieldAttr(nst: 112)] public float _startingValue;
        [FieldAttr(nst: 116)] public float _endingValue;
        [FieldAttr(nst: 120)] public float _duration;
        [FieldAttr(nst: 124)] public float _easeInDuration;
        [FieldAttr(nst: 128)] public float _easeOutDuration;
        [FieldAttr(nst: 132)] public EigEaseType _easeType;
        [FieldAttr(nst: 136)] public ESliderMode _mode;
        [FieldAttr(nst: 144, refCount: false)] public CEntity? _owner;
    }
}
