namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class C3_Egypt_Hazard_SlidingBlock_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float;
        [FieldAttr(nst: 48)] public igHandleMetaField _Vfx_Effect_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 64)] public string? _CrashDeath = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_Effect_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Sound = new();
    }
}
