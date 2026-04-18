namespace Alchemy
{
    [ObjectAttr(ctr: 96, align: 8)]
    public class CStreamingMovie : igObject
    {
        [FieldAttr(ctr: 12)] public int _id;
        [FieldAttr(ctr: 16)] public string? _url;
        [FieldAttr(ctr: 24)] public igSizeTypeMetaField[] _textureY = new igSizeTypeMetaField[2];
        [FieldAttr(ctr: 40)] public igSizeTypeMetaField[] _textureCbCr = new igSizeTypeMetaField[2];
        [FieldAttr(ctr: 56)] public igImage2[] _imageY = new igImage2[2];
        [FieldAttr(ctr: 72)] public igImage2[] _imageCbCr = new igImage2[2];
        [FieldAttr(ctr: 88)] public bool _ready;
        [FieldAttr(ctr: 92)] public uint _lock;
    }
}
