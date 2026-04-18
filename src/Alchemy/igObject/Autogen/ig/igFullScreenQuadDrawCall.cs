namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 56, align: 8)]
    public class igFullScreenQuadDrawCall : igDrawCall
    {
        [FieldAttr(nst: 24, ctr: 16)] public igVertexBuffer? _vertexBuffer;
        [FieldAttr(nst: 32, ctr: 24)] public igSizeTypeMetaField _vertexBufferResource = new();
        [FieldAttr(nst: 40, ctr: 32)] public igSizeTypeMetaField _vertexFormatResource = new();
        [FieldAttr(nst: 48, ctr: 40)] public int _primitiveCount;
        [FieldAttr(nst: 56, ctr: 48)] public igGraphicsMaterial? _material;
    }
}
