namespace Alchemy
{
    [ObjectAttr(nst: 32, align: 4)]
    public class CLinearDriftSteeringOverride : igObject
    {
        [FieldAttr(nst: 16)] public float magnitude = 1.0f;
        [FieldAttr(nst: 20)] public float decayDelay = 0.2f;
        [FieldAttr(nst: 24)] public float decayDuration = 0.4f;
        [FieldAttr(nst: 28)] public bool useBoostTurn = true;
    }
}
