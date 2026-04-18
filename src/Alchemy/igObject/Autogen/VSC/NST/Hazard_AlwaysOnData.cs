namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_AlwaysOnData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _IdleSound = new();
        [FieldAttr(nst: 48)] public string? _CrashDeath = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _IdleVfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Game_Bool_Variable = new();
    }
}
