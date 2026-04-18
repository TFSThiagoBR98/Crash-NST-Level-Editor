namespace Alchemy
{
    [ObjectAttr(nst: 72, align: 4, metaType: typeof(CVscComponentData))]
    public class common_InvisiblePlatform_MaterialSwapData : CVscComponentData
    {
        [FieldAttr(nst: 40)] public bool _RemoveOverride;
        [FieldAttr(nst: 48)] public igHandleMetaField _StartingMaterial = new();
        [FieldAttr(nst: 56)] public igHandleMetaField _NewMaterial = new();
        [FieldAttr(nst: 64)] public bool _Bool;
    }
}
