namespace Alchemy
{
    [ObjectAttr(nst: 96, align: 4, metaType: typeof(CVscComponentData))]
    public class common_Crate_TNTData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public igHandleMetaField _One = new();
        [FieldAttr(nst: 48)] public igHandleMetaField _Three = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _Two = new();
        [FieldAttr(nst: 64)] public igHandleMetaField _WarningSound = new();
        [FieldAttr(nst: 72)] public igHandleMetaField _WarningVFX = new();
        [FieldAttr(nst: 80)] public igHandleMetaField _IdleVFX = new();
        [FieldAttr(nst: 88)] public float _Float;
    }
}
