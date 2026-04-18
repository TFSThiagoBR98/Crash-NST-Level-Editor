namespace Alchemy
{
    [ObjectAttr(nst: 136, align: 8)]
    public class CLinearDriftData : CDriftData
    {
        [FieldAttr(nst: 72)] public float _speedRequiredForLinearDrifting = 1000.0f;
        [FieldAttr(nst: 76)] public float _joystickAddedVisualTurn = 4.0f;
        [FieldAttr(nst: 80)] public float _joystickAddedVisualTurnDamping = 0.2f;
        [FieldAttr(nst: 84)] public float _driftFakeTurnMultiplier = 0.75f;
        [FieldAttr(nst: 88)] public float _driftFakeTurnBaseValue = 15.0f;
        [FieldAttr(nst: 92)] public float _driftDistanceLevel2 = 5000.0f;
        [FieldAttr(nst: 96)] public float _driftDistanceLevel3 = 1.0f;
        [FieldAttr(nst: 100)] public float _driftStartFakeTurnTime = 0.2f;
        [FieldAttr(nst: 104)] public CLinearDriftSteeringOverride? _noBoostSteeringOverride;
        [FieldAttr(nst: 112)] public CLinearDriftSteeringOverride? _boostLevel2SteeringOverride;
        [FieldAttr(nst: 120)] public CLinearDriftSteeringOverride? _boostLevel3SteeringOverride;
        [FieldAttr(nst: 128)] public bool _boostTorwardsVelocity;
    }
}
