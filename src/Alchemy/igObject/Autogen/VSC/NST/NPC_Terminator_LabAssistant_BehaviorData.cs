namespace Alchemy
{
    [ObjectAttr(nst: 112, align: 4, metaType: typeof(CVscComponentData))]
    public class NPC_Terminator_LabAssistant_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _String_0x28 = null;
        [FieldAttr(nst: 48)] public string? _String_0x30 = null;
        [FieldAttr(nst: 56)] public string? _String_0x38 = null;
        [FieldAttr(nst: 64)] public float _Float_0x40;
        [FieldAttr(nst: 72)] public igHandleMetaField _Bolt_Point = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _Vfx_Effect = new();
        [FieldAttr(nst: 88)] public float _Float_0x58;
        [FieldAttr(nst: 96)] public string? _String_0x60 = null;
        [FieldAttr(nst: 104)] public float _Float_0x68;
    }
}
