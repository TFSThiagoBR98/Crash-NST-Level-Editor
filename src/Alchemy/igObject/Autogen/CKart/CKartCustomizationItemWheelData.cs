namespace Alchemy
{
    [ObjectAttr(ctr: 176, align: 16)]
    public class CKartCustomizationItemWheelData : CKartCustomizationItemBaseData
    {
        [FieldAttr(ctr: 16)] public CGameEntity? _wheelFrontLeft;
        [FieldAttr(ctr: 24)] public CGameEntity? _wheelFrontRight;
        [FieldAttr(ctr: 32)] public CGameEntity? _wheelBackLeft;
        [FieldAttr(ctr: 40)] public CGameEntity? _wheelBackRight;
        [FieldAttr(ctr: 48)] public string? _wheelFrontLeftPlayerRaceModel;
        [FieldAttr(ctr: 56)] public string? _wheelFrontRightPlayerRaceModel;
        [FieldAttr(ctr: 64)] public string? _wheelBackLeftPlayerRaceModel;
        [FieldAttr(ctr: 72)] public string? _wheelBackRightPlayerRaceModel;
        [FieldAttr(ctr: 80)] public string? _wheelFrontLeftAIRaceModel;
        [FieldAttr(ctr: 88)] public string? _wheelFrontRightAIRaceModel;
        [FieldAttr(ctr: 96)] public string? _wheelBackLeftAIRaceModel;
        [FieldAttr(ctr: 104)] public string? _wheelBackRightAIRaceModel;
        [FieldAttr(ctr: 112)] public CKartVfxObjectList? _frontPersistentEffects;
        [FieldAttr(ctr: 120)] public CKartVfxObjectList? _backPersistentEffects;
        [FieldAttr(ctr: 128)] public CKartVfxObject? _driftingEffect;
        [FieldAttr(ctr: 136)] public CKartVfxObject? _driftBoostReadyEffect;
        [FieldAttr(ctr: 144)] public igVec4fMetaField _persistentEffectsColor = new();
        [FieldAttr(ctr: 160)] public CKartSpawnedEffectBySpeedDataList? _spawnedBySpeedEffects;
    }
}
