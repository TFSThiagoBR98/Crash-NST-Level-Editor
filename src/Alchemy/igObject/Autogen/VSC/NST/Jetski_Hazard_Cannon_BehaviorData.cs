namespace Alchemy
{
    [ObjectAttr(nst: 104, align: 4, metaType: typeof(CVscComponentData))]
    public class Jetski_Hazard_Cannon_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _Entity = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 56)] public float _Float;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public string? _String_0x48 = null;
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Bolt_Point = new();
    }
}
