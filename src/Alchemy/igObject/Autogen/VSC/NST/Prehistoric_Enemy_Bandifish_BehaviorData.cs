namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class Prehistoric_Enemy_Bandifish_BehaviorData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public string? _Idle_0x28 = null;
        [FieldAttr(nst: 48)] public string? _Idle_0x30 = null;
        [FieldAttr(nst: 56)] public igHandleMetaField _SplineAttachBehaviorVariable_id_dmv9oeuf_variable = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _SplineRotationMoverVariable_id_adexbjvm_variable = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _SplineVelocityMover = new();
        [FieldAttr(nst: 80)] public float _Float;
        [FieldAttr(nst: 88)] public string? _String = null;
    }
}
