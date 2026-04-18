namespace Alchemy
{
    [ObjectAttr(nst: 120, ctr: 120, align: 8)]
    public class igGuiAnimationPlayState : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igGuiAnimation? _animation;
        [FieldAttr(nst: 24, ctr: 24)] public igGuiAnimationBinding? _binding;
        [FieldAttr(nst: 32, ctr: 32, refCount: false)] public igGuiPlaceable? _signalObject;
        [FieldAttr(nst: 40, ctr: 40)] public int _signalCount;
        [FieldAttr(nst: 48, ctr: 48, refCount: false)] public igGuiAction? _action;
        [FieldAttr(nst: 56, ctr: 56)] public int _actionCount;
        [FieldAttr(nst: 60, ctr: 60)] public bool _manualTimeControl;
        [FieldAttr(nst: 64, ctr: 64)] public float _velocity;
        [FieldAttr(nst: 68, ctr: 68)] public EigGuiAnimationLoopMode _loopMode;
        [FieldAttr(nst: 72, ctr: 72)] public igGuiAnimationCategory? _category;
        [FieldAttr(nst: 80, ctr: 80)] public igGuiProject? _project;
        [FieldAttr(nst: 88, ctr: 88)] public bool _disableControls;
        [FieldAttr(nst: 92, ctr: 92)] public igTimeMetaField _time = new();
        [FieldAttr(nst: 96, ctr: 96)] public igTimeMetaField _previousTime = new();
        [FieldAttr(nst: 100, ctr: 100)] public bool _signalOnce;
        [FieldAttr(nst: 101, ctr: 101)] public bool _deinitialized = true;
        [FieldAttr(nst: 104, ctr: 104)] public igVscDelegateMetaField _finishedCallback = new();
    }
}
