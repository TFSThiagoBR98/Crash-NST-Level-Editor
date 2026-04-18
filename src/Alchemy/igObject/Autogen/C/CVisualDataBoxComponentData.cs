namespace Alchemy
{
    [ObjectAttr(nst: 88, ctr: 80, align: 8)]
    public class CVisualDataBoxComponentData : igComponentData
    {
        public enum EAnimationType
        {
            kSpacial = 0,
            kTime = 1,
        }

        [FieldAttr(nst: 24, ctr: 16)] public igVec3fMetaField _dimensions = new();
        [FieldAttr(nst: 36, ctr: 28)] public float _transitionSizePx = 0.75f;
        [FieldAttr(nst: 40, ctr: 32)] public float _transitionSizeNx = 0.75f;
        [FieldAttr(nst: 44, ctr: 36)] public float _transitionSizePy = 0.75f;
        [FieldAttr(nst: 48, ctr: 40)] public float _transitionSizeNy = 0.75f;
        [FieldAttr(nst: 52, ctr: 44)] public float _transitionSizePz = 0.75f;
        [FieldAttr(nst: 56, ctr: 48)] public float _transitionSizeNz = 0.75f;
        [FieldAttr(nst: 60, ctr: 52)] public EPriority _priority = EPriority.kLow;
        [FieldAttr(nst: 64, ctr: 56)] public bool _state = true;
        [FieldAttr(nst: 68, ctr: 60)] public EAnimationType _animationType;
        [FieldAttr(nst: 72, ctr: 64)] public float _animationDuration = 5.0f;
        [FieldAttr(nst: 80, ctr: 72)] public CVisualDataGroup? _data;
    }
}
