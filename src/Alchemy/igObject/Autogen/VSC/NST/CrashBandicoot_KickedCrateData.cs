namespace Alchemy
{
    [ObjectAttr(nst: 56, align: 4, metaType: typeof(CVscComponentData))]
    public class CrashBandicoot_KickedCrateData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _StartCountdown;
        [FieldAttr(nst: 48)] public igHandleMetaField _StationaryCrate = new();
    }
}
