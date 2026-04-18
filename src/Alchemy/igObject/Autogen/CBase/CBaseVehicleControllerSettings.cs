namespace Alchemy
{
    [ObjectAttr(nst: 112, ctr: 112, align: 8)]
    public class CBaseVehicleControllerSettings : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public CTopSpeedVehicleSettingList? _topSpeedStat;
        [FieldAttr(nst: 24, ctr: 24)] public CAccelerationVehicleSettingList? _accelerationStat;
        [FieldAttr(nst: 32, ctr: 32)] public CManeuverVehicleSettingList? _maneuverStat;
        [FieldAttr(nst: 40, ctr: 40)] public CArmorVehicleSettingList? _armorStat;
        [FieldAttr(nst: 48, ctr: 48)] public CArenaDriftVehicleSettingList? _arenaDriftStat;
        [FieldAttr(nst: 56, ctr: 56)] public CLinearDriftVehicleSettingList? _linearDriftStat;
        [FieldAttr(nst: 64, ctr: 64)] public CDurabilityVehicleSettingList? _durabilityStat;
        [FieldAttr(nst: 72, ctr: 72)] public CWeightVehicleSettingList? _weightStat;
        [FieldAttr(nst: 80, ctr: 80)] public CInputVehicleSettings? _inputModifiersStat;
        [FieldAttr(nst: 88, ctr: 88)] public igHandleMetaField _airStatsModifier = new();
        [FieldAttr(nst: 96, ctr: 96)] public igHandleMetaField _secondarySurfaceStatsModifier = new();
        [FieldAttr(nst: 104, ctr: 104)] public CVehicleStatsList? _activeStatsModifiers;
    }
}
