namespace Alchemy
{
    [ObjectAttr(ctr: 296, align: 8)]
    public class CKartAISystemData : igSingleton
    {
        [FieldAttr(ctr: 16)] public CDifficultySpecificFloat? _powerUpTargetingMaximumDistance;
        [FieldAttr(ctr: 24)] public CDifficultySpecificFloat? _powerUpTargetingConeBaseRadiusDistance;
        [FieldAttr(ctr: 32)] public CDifficultySpecificFloat? _powerUpTargetingConeAngle;
        [FieldAttr(ctr: 40)] public CDifficultySpecificFloat? _targetLockingTime;
        [FieldAttr(ctr: 48)] public CDifficultySpecificFloat? _battlePowerUpTargetingMaximumDistance;
        [FieldAttr(ctr: 56)] public CDifficultySpecificFloat? _battlePowerUpTargetingConeBaseRadiusDistance;
        [FieldAttr(ctr: 64)] public CDifficultySpecificFloat? _battlePowerUpTargetingConeAngle;
        [FieldAttr(ctr: 72)] public CDifficultySpecificFloat? _battleTargetLockingTime;
        [FieldAttr(ctr: 80)] public CDifficultySpecificFloat? _battleDelayBetweenAttacks;
        [FieldAttr(ctr: 88)] public CDifficultySpecificPowerUpWeightListData? _storyPowerUpWeights;
        [FieldAttr(ctr: 96)] public CDifficultySpecificPowerUpWeightListData? _arcadePowerUpWeights;
        [FieldAttr(ctr: 104)] public CDifficultySpecificHurtRubberbandDataTable? _hurtRubberbandData;
        [FieldAttr(ctr: 112)] public CDifficultySpecificHurtRubberbandData? _fallInHoleRubberbandData;
        [FieldAttr(ctr: 120)] public CDifficultySpecificFloat? _maximumHurtRubberbandAddedTime;
        [FieldAttr(ctr: 128)] public CDifficultySpecificInt? _maximumSuccessfulBoost;
        [FieldAttr(ctr: 136)] public CDifficultySpecificFloat? _boostSuccessChance;
        [FieldAttr(ctr: 144)] public CDifficultySpecificFloat? _lateFailureChance;
        [FieldAttr(ctr: 152)] public CDifficultySpecificInt? _firstRacersAvoidingHazardCount;
        [FieldAttr(ctr: 160)] public CDifficultySpecificFloat? _maximumVelocity;
        [FieldAttr(ctr: 168)] public CDifficultySpecificFloat? _endRaceMaximumVelocity;
        [FieldAttr(ctr: 176)] public CDifficultySpecificFloat? _nemesisAllowedSpeedRatio;
        [FieldAttr(ctr: 184)] public CTargetAquisitionData? _targetAcquisitionData;
        [FieldAttr(ctr: 192)] public CDifficultySpecificFloat? _powerUpShuffleInterruptionDelay;
        [FieldAttr(ctr: 200)] public CDifficultySpecificFloat? _arenaGracePeriodTime;
        [FieldAttr(ctr: 208)] public CDifficultySpecificFloat? _arenaCaptureTheFlagPickUpGracePeriodTime;
        [FieldAttr(ctr: 216)] public CDifficultySpecificFloat? _arenaStealTheBaconPickUpGracePeriodTime;
        [FieldAttr(ctr: 224)] public CDifficultySpecificInt? _arenaMinCrystalToChase;
        [FieldAttr(ctr: 232)] public CDifficultySpecificFloat? _arenaCaptureTheFlagFirstFlagDelay;
        [FieldAttr(ctr: 240)] public CDifficultySpecificFloat? _arenaCaptureTheFlagDelayBetweenFlagGatherer;
        [FieldAttr(ctr: 248)] public CDifficultySpecificFloat? _arenaCaptureTheFlagFlagReturnedDelay;
        [FieldAttr(ctr: 256)] public CDifficultySpecificFloat? _arenaStealTheBaconFirstFlagDelay;
        [FieldAttr(ctr: 264)] public CDifficultySpecificFloat? _arenaStealTheBaconDelayBetweenFlagGatherer;
        [FieldAttr(ctr: 272)] public CDifficultySpecificFloat? _arenaStealTheBaconFlagReturnedDelay;
        [FieldAttr(ctr: 280)] public CDifficultySpecificFloat? _arenaMaximumVelocity;
        [FieldAttr(ctr: 288)] public CDifficultySpecificFloat? _arenaCrystalMinimumActiveTimeToBeGrabbed;
    }
}
