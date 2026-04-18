namespace Alchemy
{
    [ObjectAttr(nst: 80, ctr: 64, align: 8)]
    public class igVfxDrawProcGeometryOperator : igVfxDrawTexturedOperator
    {
        [ObjectAttr(size: 4)]
        public class DrawProcGeomFlags : igBitFieldMetaField
        {
            [FieldAttr(offset: 0, size: 1)] public bool _useUniqueGeometry;
            [FieldAttr(offset: 1, size: 8)] public int _nextProcGeometryOperator;
            [FieldAttr(offset: 9, size: 4)] public int _procGeometryOperatorIndex;
            [FieldAttr(offset: 13, size: 10)] public int _vertexCost;
        }

        [FieldAttr(nst: 72, ctr: 56)] public DrawProcGeomFlags _drawProcGeomFlags = new();
    }
}
