namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 104, align: 8)]
    public class igGuiActionPlayAnimation : igGuiAction
    {
        [FieldAttr(nst: 48, ctr: 40, refCount: false)] public igGuiAnimationTag? _animation;
        [FieldAttr(nst: 56, ctr: 48, refCount: false)] public igGuiPlaceable? _placeable;
        [FieldAttr(nst: 64, ctr: 56)] public igTimeMetaField _startTime = new();
        [FieldAttr(nst: 68, ctr: 60)] public float _speed = 1.0f;
        [FieldAttr(nst: 72, ctr: 64)] public bool _reverse;
        [FieldAttr(nst: 76, ctr: 68)] public EigGuiAnimationLoopMode _loopMode;
        [FieldAttr(nst: 80, ctr: 72)] public bool _manualTimeControl;
        [FieldAttr(nst: 88, ctr: 80)] public igGuiAnimationCategory? _category;
        [FieldAttr(nst: 96, ctr: 88)] public bool _disableControls;
        [FieldAttr(nst: 97, ctr: 89)] public bool _onTree = true;
        [FieldAttr(nst: 98, ctr: 90)] public bool _onRoot;
        [FieldAttr(nst: 100, ctr: 92)] public float _animationLength;
        [FieldAttr(nst: 104, ctr: 96, refCount: false)] public igGuiPlaceable? _signalObject;
    }
}
