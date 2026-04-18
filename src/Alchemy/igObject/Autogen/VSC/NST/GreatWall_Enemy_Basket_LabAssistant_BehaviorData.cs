namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class GreatWall_Enemy_Basket_LabAssistant_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _Spline_Attach_Behavior = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Spline_Rotation_Mover = new();
        [FieldAttr(nst: 80)] public float _Float;
        [FieldAttr(nst: 88)] public igHandleMetaField _Entity = new();
    }
}
