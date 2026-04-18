namespace Alchemy
{
    [ObjectAttr(nst: 272, align: 8)]
    public class CVehicleComponentData : CEntityComponentData
    {
        [FieldAttr(nst: 24)] public igComponentDataTable? _arenaComponentTable;
        [FieldAttr(nst: 32)] public igComponentDataTable? _linearComponentTable;
        [FieldAttr(nst: 40)] public igComponentDataTable? _classicComponentTable;
        [FieldAttr(nst: 48)] public igComponentDataTable? _expeditionComponentTable;
        [FieldAttr(nst: 56)] public string? _enterArenaEvent = "Locomotion_Arena_Idle";
        [FieldAttr(nst: 64)] public string? _enterLinearEvent = "Locomotion_Linear_Idle";
        [FieldAttr(nst: 72)] public string? _enterClassicEvent = "Locomotion_Arena_Idle";
        [FieldAttr(nst: 80)] public string? _enterExpeditionEvent = null;
        [FieldAttr(nst: 88)] public CVehicleRiderComponentData? _riderComponent;
        [FieldAttr(nst: 96)] public CBoltPoint? _primaryModCameraLookAtBolt;
        [FieldAttr(nst: 104)] public CBoltPoint? _primaryModCameraPositionBolt;
        [FieldAttr(nst: 112)] public float _primaryModCameraFov = 80.0f;
        [FieldAttr(nst: 120)] public CBoltPoint? _primaryModVortexBolt;
        [FieldAttr(nst: 128)] public igVec2fMetaField _primaryModGuiPosition = new();
        [FieldAttr(nst: 136)] public CBoltPoint? _secondaryModCameraLookAtBolt;
        [FieldAttr(nst: 144)] public CBoltPoint? _secondaryModCameraPositionBolt;
        [FieldAttr(nst: 152)] public float _secondaryModCameraFov = 80.0f;
        [FieldAttr(nst: 160)] public CBoltPoint? _secondaryModVortexBolt;
        [FieldAttr(nst: 168)] public igVec2fMetaField _secondaryModGuiPosition = new();
        [FieldAttr(nst: 176)] public CBoltPoint? _hornCameraLookAtBolt;
        [FieldAttr(nst: 184)] public CBoltPoint? _hornCameraPositionBolt;
        [FieldAttr(nst: 192)] public float _hornCameraFov = 80.0f;
        [FieldAttr(nst: 200)] public CBoltPoint? _hornVortexBolt;
        [FieldAttr(nst: 208)] public igVec2fMetaField _hornGuiPosition = new();
        [FieldAttr(nst: 216)] public CBoltPoint? _antennaCameraLookAtBolt;
        [FieldAttr(nst: 224)] public CBoltPoint? _antennaCameraPositionBolt;
        [FieldAttr(nst: 232)] public float _antennaCameraFov = 80.0f;
        [FieldAttr(nst: 240)] public CBoltPoint? _antennaVortexBolt;
        [FieldAttr(nst: 248)] public igVec2fMetaField _antennaGuiPosition = new();
        [FieldAttr(nst: 256)] public float _vehiclePortalDelay = 0.5f;
        [FieldAttr(nst: 260)] public bool _gunnerCanBePassenger;
        [FieldAttr(nst: 264)] public EVehicleType _vehicleType;
    }
}
