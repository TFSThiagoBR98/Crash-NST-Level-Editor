namespace Alchemy
{
    [ObjectAttr(nst: 120, align: 4, metaType: typeof(CVscComponentData))]
    public class Hazard_Timed_Trigger_Volume_ActivationData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _StartOn;
        [FieldAttr(nst: 44)] public float _Timer_0x2c;
        [FieldAttr(nst: 48)] public igHandleMetaField _Unnamed_Vfx_Effect = new();
        [FieldAttr(nst: 56)] public float _Timer_0x38;
        [FieldAttr(nst: 64)] public igHandleMetaField _Bolt_Point_0x40 = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point_0x48 = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Bolt_Point_0x50 = new();
        [FieldAttr(nst: 88)] public igHandleMetaField _Vfx_Effect_0x58 = new();
        [FieldAttr(nst: 96)] public igHandleMetaField _Vfx_Effect_0x60 = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Bolt_Point_0x68 = new();
        [FieldAttr(nst: 112)] public bool _Bool;
    }
}
