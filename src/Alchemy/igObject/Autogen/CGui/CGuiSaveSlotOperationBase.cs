namespace Alchemy
{
    [ObjectAttr(nst: 72, ctr: 72, align: 8)]
    public class CGuiSaveSlotOperationBase : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CGuiSaveSlotAnimations? _animations;
        [FieldAttr(nst: 24, ctr: 24)] public EigGuiAnimationLoopMode _animIdleLoopMode = EigGuiAnimationLoopMode.kGuiLoopRepeat;
        [FieldAttr(nst: 32, ctr: 32)] public igGuiAnimationCategory? _animationCategory;
        [FieldAttr(nst: 40, ctr: 40)] public int _currentSlot = -1;
        [FieldAttr(nst: 44, ctr: 44)] public bool _completedSuccessfully;
        [FieldAttr(ctr: 45)] public bool _bypassSaveOperation;
        [FieldAttr(nst: 48, ctr: 48)] public EButtonLegendButton _button;
        [FieldAttr(nst: 56, ctr: 56)] public string? _legendText = null;
        [FieldAttr(nst: 64, ctr: 64)] public bool _legendTextAdded;
    }
}
