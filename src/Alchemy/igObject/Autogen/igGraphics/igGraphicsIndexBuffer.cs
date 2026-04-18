namespace Alchemy
{
    [ObjectAttr(nst: 48, ctr: 48, align: 8)]
    public class igGraphicsIndexBuffer : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public EigResourceUsage _usage;
        [FieldAttr(nst: 32, ctr: 32)] public igIndexBuffer? _indexBuffer;
        [FieldAttr(nst: 40)] public igSizeTypeMetaField _resource = new();
        [FieldAttr(ctr: 40)] public igGraphicsResourceObject? _resourceRef;
    }
}
