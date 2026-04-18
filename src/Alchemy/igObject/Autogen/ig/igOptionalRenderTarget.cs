namespace Alchemy
{
    [ObjectAttr(ctr: 256, align: 8)]
    public class igOptionalRenderTarget : igRenderTarget
    {
        [FieldAttr(ctr: 224)] public igHandleMetaField _optionalRenderTarget = new();
        [FieldAttr(ctr: 232)] public igHandleMetaField _renderTarget = new();
        [FieldAttr(ctr: 240)] public igHandleMetaField _originalParentTarget = new();
        [FieldAttr(ctr: 248)] public igHandleMetaField _optionalEnableData = new();
    }
}
