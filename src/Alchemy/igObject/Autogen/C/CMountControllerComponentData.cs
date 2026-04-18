namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4)]
    public class CMountControllerComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public float _jumpDecideTime = 0.1f;
        [FieldAttr(nst: 28)] public float _jumpPauseTime = 0.2667f;
        [FieldAttr(nst: 32)] public float _jumpInterpolateTime = 0.1f;
        [FieldAttr(nst: 36)] public float _jumpVelocity = 200.0f;
        [FieldAttr(nst: 40)] public float _baseBounceVelocity = 300.0f;
        [FieldAttr(nst: 44)] public float _heldBounceVelocity = 600.0f;
        [FieldAttr(nst: 48)] public float _additionalHangTimeFraction;
        [FieldAttr(nst: 52)] public bool _canPitJump = true;
        [FieldAttr(nst: 56)] public float _maxGroundDistance = 15.0f;
        [FieldAttr(nst: 60)] public float _traceDistance = 400.0f;
    }
}
