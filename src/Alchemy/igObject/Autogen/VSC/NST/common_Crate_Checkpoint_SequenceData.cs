namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crate_Checkpoint_SequenceData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _IsIronCrate;
        [FieldAttr(nst: 48)] public igHandleMetaField _CheckpointSound = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _OpenSound = new();
        [FieldAttr(nst: 64)] public string? _OpenAnimation = null;
        [FieldAttr(nst: 72)] public igHandleMetaField _OpenVFX = new();
        [FieldAttr(nst: 80)] public bool _Bool;
        [FieldAttr(nst: 88)] public igHandleMetaField _Sound = new();
    }
}
