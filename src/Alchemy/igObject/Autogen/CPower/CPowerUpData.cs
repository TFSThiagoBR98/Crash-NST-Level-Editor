namespace Alchemy
{
    [ObjectAttr(ctr: 144, align: 8)]
    public class CPowerUpData : igObject
    {
        [FieldAttr(ctr: 16)] public CPowerUpGameModesTable? _powerUpByGameMode;
        [FieldAttr(ctr: 24)] public CPowerUpGameModesTable? _onlinePowerUpByGameMode;
        [FieldAttr(ctr: 32)] public CPowerUpCooldownHashTable? _powerUpCooldowns;
        [FieldAttr(ctr: 40)] public CLargeBowlingBombComponentData? _bowlingBombData;
        [FieldAttr(ctr: 48)] public CTrackingMissileComponentData? _trackingMissileData;
        [FieldAttr(ctr: 56)] public CExplosiveCrateComponentData? _explosiveCrateData;
        [FieldAttr(ctr: 64)] public CBeakerComponentData? _beakerData;
        [FieldAttr(ctr: 72)] public CInvincibilityMaskComponentData? _invincibilityMaskData;
        [FieldAttr(ctr: 80)] public CNTropyComponentData? _nTropyData;
        [FieldAttr(ctr: 88)] public CTurboBoostComponentData? _turboBoostData;
        [FieldAttr(ctr: 96)] public CWarpOrbComponentData? _warpOrbData;
        [FieldAttr(ctr: 104)] public CPowerShieldComponentData? _powerShieldData;
        [FieldAttr(ctr: 112)] public CSuperEngineComponentData? _superEngineData;
        [FieldAttr(ctr: 120)] public CInvisibilityComponentData? _invisibilityData;
        [FieldAttr(ctr: 128)] public CMultiPowerUpComponentData? _multiPowerUpData;
        [FieldAttr(ctr: 136)] public CPowerUpNamesTable? _powerUpNamesTable;
    }
}
