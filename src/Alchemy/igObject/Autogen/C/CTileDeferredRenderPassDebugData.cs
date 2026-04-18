namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class CTileDeferredRenderPassDebugData : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVectorMetaField<igSprite> _sprites = new();
        [FieldAttr(nst: 40, ctr: 40)] public igVectorMetaField<igText> _texts = new();
    }
}
