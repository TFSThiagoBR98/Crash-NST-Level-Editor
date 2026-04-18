namespace Alchemy
{
    [ObjectAttr(nst: 344, ctr: 328, align: 8)]
    public class CVehicleSystemData : igObject
    {
        public enum EVehicleCollisionReaction
        {
            eVCR_None = -1,
            eVCR_Minor = 0,
            eVCR_Moderate = 1,
            eVCR_Major = 2,
        }

        [FieldAttr(nst: 16, ctr: 12)] public float _armorStatConstant = 100.0f;
        [FieldAttr(nst: 20, ctr: 16)] public float _massForMinWeight = 100.0f;
        [FieldAttr(nst: 24, ctr: 20)] public float _massForMaxWeight = 1.0f;
        [FieldAttr(nst: 32, ctr: 24)] public CVehicleCollisionResponseCriteriaList? _collisionResponseCriteria;
        [FieldAttr(nst: 40, ctr: 32)] public CVehicleCollisionSpeedMassModList? _speedMassModifcations;
        [FieldAttr(nst: 48, ctr: 40)] public CVehicleCollisionDriftMassModList? _driftMassModifcations;
        [FieldAttr(nst: 56, ctr: 48)] public igVfxRangedCurveMetaField _collisionDamageMultiplierByWeightDifference = new();
        [FieldAttr(nst: 140, ctr: 132)] public igVfxRangedCurveMetaField _collisionVelocityTransferredByWeight = new();
        [FieldAttr(nst: 224, ctr: 216)] public float _knockawayFromCollisionDuration = 0.1f;
        [FieldAttr(nst: 228, ctr: 220)] public float _knockawayFromCollisionForceMultiplier = 1.0f;
        [FieldAttr(nst: 232, ctr: 224)] public float _knockawayAngularTime = 0.1f;
        [FieldAttr(nst: 240, ctr: 232)] public CVehicleSection? _debugDefaultVehicleSection;
        [FieldAttr(nst: 248)] public CVehicleSwapData? _vehicleSwapData;
        [FieldAttr(nst: 256, ctr: 240)] public int _topSpeedStatToMatchBoost = 95;
        [FieldAttr(nst: 260, ctr: 244)] public float _superChargeDamageMultiplier = 1.1f;
        [FieldAttr(nst: 264, ctr: 248)] public CDifficultySpecificFloat? _skylanderDamageReductionMultiplier;
        [FieldAttr(nst: 272, ctr: 256)] public igHandleMetaField _onlyDriversCanModSwapVo = new();
        [FieldAttr(nst: 280, ctr: 264)] public igHandleMetaField _onlyDriversCanModSwapHugoVo = new();
        [FieldAttr(nst: 288, ctr: 272)] public igHandleMetaField _hugoObjectiveRequirement = new();
        [FieldAttr(nst: 296, ctr: 280)] public CVehiclePersonalizationSetItemList? _vehiclePersonalizationSets;
        [FieldAttr(nst: 304, ctr: 288)] public CVehiclePersonalizationColorSchemeItemList? _vehiclePersonalizationColorScheme;
        [FieldAttr(nst: 312, ctr: 296)] public CVehiclePersonalizationTopperItemList? _vehiclePersonalizationToppers;
        [FieldAttr(nst: 320, ctr: 304)] public CVehiclePersonalizationNeonItemList? _vehiclePersonalizationNeon;
        [FieldAttr(nst: 328, ctr: 312)] public CVehiclePersonalizationTauntItemList? _vehiclePersonalizationTaunts;
        [FieldAttr(nst: 336, ctr: 320)] public CVehiclePersonalizationBoostItemList? _vehiclePersonalizationBoosts;
    }
}
