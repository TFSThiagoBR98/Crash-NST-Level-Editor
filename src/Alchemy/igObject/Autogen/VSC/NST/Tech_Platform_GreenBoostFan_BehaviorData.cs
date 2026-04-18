namespace Alchemy
{
    [ObjectAttr(nst: 88, align: 4, metaType: typeof(CVscComponentData))]
    public class Tech_Platform_GreenBoostFan_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _Bounce_0x28 = null;
        [FieldAttr(nst: 48)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Bounce_Vfx = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Crash_Bandicoot_Bounce_Data = new();
        [FieldAttr(nst: 72)] public string? _Bounce_0x48 = null;
        [FieldAttr(nst: 80)] public igHandleMetaField _Bounce_Sfx = new();
    }
}
