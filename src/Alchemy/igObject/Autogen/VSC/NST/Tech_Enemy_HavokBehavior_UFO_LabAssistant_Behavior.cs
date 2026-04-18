namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class Tech_Enemy_HavokBehavior_UFO_LabAssistant_Behavior : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public string? _String_0x40 = null;
        [FieldAttr(nst: 72)] public float _Float;
        [FieldAttr(nst: 80)] public string? _String_0x50 = null;
        [FieldAttr(nst: 88)] public bool _Bool_0x58;
        [FieldAttr(nst: 89)] public bool _Bool_0x59;
        [FieldAttr(nst: 96)] public igHandleMetaField _Spline_Velocity_Mover = new();
        [FieldAttr(nst: 104)] public igHandleMetaField _Spline_Rotation_Mover = new();
    }
}
