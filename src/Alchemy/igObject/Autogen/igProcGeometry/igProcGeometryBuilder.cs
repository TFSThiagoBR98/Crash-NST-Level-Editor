namespace Alchemy
{
    [ObjectAttr(nst: 64, ctr: 64, align: 8)]
    public class igProcGeometryBuilder : igObject
    {
        [FieldAttr(nst: 16, ctr: 16)] public igVertexFormat? _vertexFormat;
        [FieldAttr(nst: 24, ctr: 24)] public EIG_GFX_DRAW _primitiveType;
        [FieldAttr(nst: 28, ctr: 28)] public uint _componentFlags;
        [FieldAttr(nst: 32, ctr: 32)] public int[] _iteratorIndex = new int[8];
    }
}
