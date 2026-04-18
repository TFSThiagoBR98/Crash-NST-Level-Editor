namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class FlyTrap_CrashCocoDeathBehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Vfx_Effect_0x38 = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Entity_Tag = new();
    }
}
