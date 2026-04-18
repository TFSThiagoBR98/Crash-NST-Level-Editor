namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 48, align: 4)]
    public class CFilterByVision : CFilterMethod
    {
        public enum EFacing
        {
            eF_EntityDirection = 0,
            eF_LastPressedStickDirection = 1,
        }

        [FieldAttr(nst: 24, ctr: 16)] public float _maxLeftRightDistance = 300.0f;
        [FieldAttr(nst: 28, ctr: 20)] public float _forwardCutoff = 300.0f;
        [FieldAttr(nst: 32, ctr: 24)] public float _maxForwardDistance = 1000.0f;
        [FieldAttr(nst: 36, ctr: 28)] public float _maxVerticalDistance = 300.0f;
        [FieldAttr(nst: 40, ctr: 32)] public float _lowerVerticalOffset;
        [FieldAttr(nst: 44, ctr: 36)] public float _upperVerticalOffset;
        [FieldAttr(nst: 48, ctr: 40)] public bool _circularSweep;
        [FieldAttr(nst: 49, ctr: 41)] public bool _useYawOnly;
        [FieldAttr(nst: 52, ctr: 44)] public EFacing _facing;
    }
}
