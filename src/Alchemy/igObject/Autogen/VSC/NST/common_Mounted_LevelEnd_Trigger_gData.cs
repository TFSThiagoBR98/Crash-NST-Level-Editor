namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Mounted_LevelEnd_Trigger_gData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Game_Bool_Variable = new();
        [FieldAttr(nst: 48)] public bool _IsDebugOn;
        [FieldAttr(nst: 56)] public string? _BehaviorEventCrashTeleportOutStart = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 72)] public float _MoveCrashCenterEaseRatioIn;
        [FieldAttr(nst: 76)] public float _MoveCrashCenterTime;
        [FieldAttr(nst: 80)] public float _MoveCrashCenterEaseRatioOut;
        [FieldAttr(nst: 84)] public EigEaseType _MoveCrashCenterEaseType;
        [FieldAttr(nst: 88)] public float _Float;
    }
}
