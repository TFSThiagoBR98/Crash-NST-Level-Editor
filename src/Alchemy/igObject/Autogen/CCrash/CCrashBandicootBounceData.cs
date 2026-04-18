namespace Alchemy
{
    [ObjectAttr(nst: 64, align: 4)]
    public class CCrashBandicootBounceData : igObject
    {
        [FieldAttr(nst: 16)] public float _jumpHeight;
        [FieldAttr(nst: 20)] public float _jumpRiseTime;
        [FieldAttr(nst: 24)] public float _fallTime;
        [FieldAttr(nst: 28)] public float _jumpHeightWhenJumpIsHeld;
        [FieldAttr(nst: 32)] public float _jumpRiseTimeWhenJumpIsHeld;
        [FieldAttr(nst: 36)] public float _jumpFallTimeWhenJumpWasHeld;
        [FieldAttr(nst: 40)] public float _jumpRiseTimeWhenJumpIsReleased;
        [FieldAttr(nst: 44)] public float _xyMovementSpeed = 380.0f;
        [FieldAttr(nst: 48)] public float _xyMovementDamping = 0.25f;
        [FieldAttr(nst: 52)] public float _airMovementInputThrottle = 3.5f;
        [FieldAttr(nst: 56)] public bool _forceBounce;
    }
}
