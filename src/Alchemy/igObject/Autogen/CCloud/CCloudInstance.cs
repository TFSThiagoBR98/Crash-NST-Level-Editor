namespace Alchemy
{
    [ObjectAttr(ctr: 288, align: 8)]
    public class CCloudInstance : igObject
    {
        [FieldAttr(ctr: 16)] public igSizeTypeMetaField[] _indexResources = new igSizeTypeMetaField[12];
        [FieldAttr(ctr: 112)] public igModelDrawCallData? _drawCallData;
        [FieldAttr(ctr: 120)] public igModelDrawCallData? _originalDrawCallData;
        [FieldAttr(ctr: 128)] public igMatrix44fMetaField[] _transform = new igMatrix44fMetaField[2];
        [FieldAttr(ctr: 256)] public int _index;
        [FieldAttr(ctr: 264)] public igModelDrawCall? _drawCall;
        [FieldAttr(ctr: 272)] public int _lastDirection;
    }
}
