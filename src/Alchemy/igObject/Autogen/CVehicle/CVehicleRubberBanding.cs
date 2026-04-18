namespace Alchemy
{
    [ObjectAttr(nst: 40, align: 4)]
    public class CVehicleRubberBanding : igObject
    {
        [FieldAttr(nst: 16)] public float _distanceForMaxRubberBanding = 5.0f;
        [FieldAttr(nst: 20)] public float _boostDurationMultiplier = 1.0f;
        [FieldAttr(nst: 24)] public float _boostForceMultiplier = 1.0f;
        [FieldAttr(nst: 28)] public float _powerUpDurationMultiplier = 1.0f;
        [FieldAttr(nst: 32)] public float _ammoRegenRateMultiplier = 1.0f;
        [FieldAttr(nst: 36)] public float _deathDurationMultiplier = 1.0f;
    }
}
