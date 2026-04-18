namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Respawn_LogicData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _DeathCamera = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _CrashRidingPlatform = new();
        [FieldAttr(nst: 56)] public string? _OverrideFallingDeathClip = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Sound = new();
        [FieldAttr(nst: 80)] public bool _Bool;
    }
}
