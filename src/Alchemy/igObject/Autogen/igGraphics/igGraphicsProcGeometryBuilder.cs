namespace Alchemy
{
    [ObjectAttr(ctr: 104, align: 8)]
    public class igGraphicsProcGeometryBuilder : igProcGeometryBuilder
    {
        [FieldAttr(ctr: 64)] public igProcGeometryDrawCallDataPool[] _drawCallPool = new igProcGeometryDrawCallDataPool[2];
        [FieldAttr(ctr: 80)] public igDynamicBuffer? _procGeometryBuffer;
        [FieldAttr(ctr: 88)] public igSizeTypeMetaField _format = new();
        [FieldAttr(ctr: 96)] public bool _ownsPools;
    }
}
