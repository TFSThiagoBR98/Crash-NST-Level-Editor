namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 8)]
    public class CVector3SliderNodeData : igObject
    {
        [FieldAttr(nst: 16)] public CVectorSlider? _slider;
        [FieldAttr(nst: 24)] public igVscDelegateMetaField _reachedStartCallback = new();
        [FieldAttr(nst: 40)] public igVscDelegateMetaField _updatingCallback = new();
        [FieldAttr(nst: 56)] public igVscDelegateMetaField _reachedEndCallback = new();
        [FieldAttr(nst: 72)] public igVscVec3fDelegateMetaField _currentValue = new();
    }
}
