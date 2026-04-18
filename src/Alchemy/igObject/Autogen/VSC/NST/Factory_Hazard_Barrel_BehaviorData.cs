namespace Alchemy
{
    [ObjectAttr(nst: 128, align: 4, metaType: typeof(CVscComponentData))]
    public class Factory_Hazard_Barrel_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _Bouncing;
        [FieldAttr(nst: 48)] public igHandleMetaField _SplineOffsetAttachBehavior = new();
        [FieldAttr(nst: 56)] public string? _RollAnimation_0x38 = null;
        [FieldAttr(nst: 64)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 72)] public string? _RollAnimation_0x48 = null;
        [FieldAttr(nst: 80)] public igHandleMetaField _Spline_Event_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Spline_Event_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Vfx_Effect_0x68 = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Vfx_Effect_0x70 = new();
        [FieldAttr(nst: 120)] public igHandleMetaField _Vfx_Effect_0x78 = new();
    }
}
