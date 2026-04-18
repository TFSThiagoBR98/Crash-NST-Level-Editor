namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class common_JetPackVehicleData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity_0x28 = new();
        [FieldAttr(nst: 48)] public float _MoveCrashCenterEaseRatioOut;
        [FieldAttr(nst: 52)] public EigEaseType _MoveCrashCenterEaseType;
        [FieldAttr(nst: 56)] public float _MoveCrashCenterTime_0x38;
        [FieldAttr(nst: 60)] public float _MoveCrashCenterEaseRatioIn;
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_0x40 = new();
        [FieldAttr(nst: 72)] public float _MoveCrashCenterTime_0x48;
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public string? _String_0x58 = null;
        [FieldAttr(nst: 96)] public igHandleMetaField _Sound = new();
    }
}
