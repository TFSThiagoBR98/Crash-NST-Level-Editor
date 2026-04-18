namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 8)]
    public class CDeathHandlingLogic : CBehaviorLogic
    {
        [FieldAttr(nst: 80)] public float _removalDelay;
        [FieldAttr(nst: 84)] public float _fadeStartDelay;
        [FieldAttr(nst: 88)] public float _fadeDuration = 0.5f;
    }
}
