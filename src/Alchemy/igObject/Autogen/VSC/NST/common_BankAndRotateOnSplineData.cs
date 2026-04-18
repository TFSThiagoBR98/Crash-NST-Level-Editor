namespace Alchemy
{
    [ObjectAttr(nst: 144, align: 4, metaType: typeof(CVscComponentData))]
    public class common_BankAndRotateOnSplineData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public float _Float_0x28;
        [FieldAttr(nst: 48)] public igHandleMetaField _Entity_0x30 = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Entity_0x38 = new();
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 80)] public string? _String = null;
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Spline_Attach_Behavior = new();
        [FieldAttr(nst: 112)] public igHandleMetaField _Spline_Rotation_Mover = new();
        [FieldAttr(nst: 120)] public bool _Bool;
        [FieldAttr(nst: 128)] public igHandleMetaField _Entity_0x80 = new();
        [FieldAttr(nst: 136)] public igHandleMetaField _Debug_Update_Channel = new();
    }
}
