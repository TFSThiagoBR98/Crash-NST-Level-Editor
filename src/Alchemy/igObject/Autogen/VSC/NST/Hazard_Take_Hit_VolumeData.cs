namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Take_Hit_VolumeData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _DamagedInvulnerable = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _CrashRidingPlatform = new();
        [FieldAttr(nst: 56)] public string? _HazardDeathState = null;
        [FieldAttr(nst: 64)] public bool _Bool;
        [FieldAttr(nst: 68)] public float _Float;
    }
}
