namespace Alchemy
{
    [ObjectAttr(nst: 56, ctr: 56, align: 8)]
    public class igGraphicsVertexBuffer : igGraphicsObject
    {
        [FieldAttr(nst: 24, ctr: 24)] public EigResourceUsage _usage;
        [FieldAttr(nst: 32, ctr: 32)] public igVertexBuffer? _vertexBuffer;
        [FieldAttr(nst: 40)] public igSizeTypeMetaField _bufferResource = new();
        [FieldAttr(nst: 48)] public igSizeTypeMetaField _formatResource = new();
        [FieldAttr(ctr: 40)] public igGraphicsResourceObject? _bufferResourceRef;
        [FieldAttr(ctr: 48)] public igGraphicsResourceObject? _formatResourceRef;
    }
}
