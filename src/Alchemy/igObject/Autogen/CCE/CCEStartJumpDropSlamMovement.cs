namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CCEStartJumpDropSlamMovement : CCombatNodeEvent
    {
        [FieldAttr(nst: 80)] public float _initialFallSpeed = 350.0f;
        [FieldAttr(nst: 84)] public float _gravityMultiplier = 1.0f;
        [FieldAttr(nst: 88)] public float _maxFallSpeedMultiplier = 1.0f;
    }
}
