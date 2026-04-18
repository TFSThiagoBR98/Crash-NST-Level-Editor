namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 8)]
    public class JuiceScene : JuiceVisual
    {
        [FieldAttr(nst: 40, ctr: 40)] public float _dofX = 200.0f;
        [FieldAttr(nst: 44, ctr: 44)] public float _dofY = 400.0f;
        [FieldAttr(nst: 48, ctr: 48)] public float _dofZ = 3000.0f;
        [FieldAttr(nst: 52, ctr: 52)] public float _dofW = 6500.0f;
        [FieldAttr(nst: 56, ctr: 56)] public float _nearClipPlane = 32.0f;
        [FieldAttr(nst: 60, ctr: 60)] public float _farClipPlane = 2.0f;
        [FieldAttr(nst: 64, ctr: 64)] public JuiceAnimationList? _animList;
        [FieldAttr(nst: 72, ctr: 72)] public JuiceFieldValueList? _prevAnimFieldValues;
        [FieldAttr(nst: 80, ctr: 80)] public igCinematicAnimationInstanceList? _activeAnims;
        [FieldAttr(nst: 88, ctr: 88)] public igObject? _dataBind;
        [FieldAttr(nst: 96, ctr: 96)] public igDataBindingList? _dataBindingList;
        [FieldAttr(nst: 104, ctr: 104)] public float _time;
    }
}
